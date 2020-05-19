using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AnimalInfo.DTO;

namespace AnimalInfo.DAL
{
    public class AnimalInfo_DAL
    {
        private string conectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=\"" + 
                                         System.IO.Directory.GetCurrentDirectory() + 
                                         "\\BancoDados\\Animais.mdf\";Integrated Security=True;" + 
                                         "Connect Timeout=30;User Instance=True";

        public List<Animal> BuscarAnimais()
        {
            using (SqlConnection conexao = new SqlConnection(conectionString))
            {
                List<Animal> animais = new List<Animal>();
                string select = "SELECT*FROM tb_animalInfo";

                using (SqlCommand busca = new SqlCommand(select, conexao))
                {
                    SqlDataReader leitorDeDados = null;
                    try
                    {
                        conexao.Open();
                        leitorDeDados = busca.ExecuteReader();

                        if (leitorDeDados.HasRows)
                        {
                            while (leitorDeDados.Read())
                            {
                                Animal animal = new Animal();
                                animal.nome = leitorDeDados["nome"].ToString();
                                animal.filo = leitorDeDados["filo"].ToString();
                                animal.classe = leitorDeDados["classe"].ToString();
                                animal.ordem = leitorDeDados["ordem"].ToString();
                                animal.familia = leitorDeDados["familia"].ToString();
                                animal.habitat = leitorDeDados["habitat"].ToString();
                                animal.estado_de_conservacao = leitorDeDados["estado_conservacao"].ToString();
                                animal.foto = leitorDeDados["foto"].ToString();
                                animal.descricao = leitorDeDados["descricao"].ToString();
                                animais.Add(animal);
                            }
                        }
                    }
                    catch
                    {
                        throw;
                    }
                    finally
                    {
                        if (leitorDeDados != null)
                        {
                            leitorDeDados.Dispose();
                        }
                    }
                    return animais;
                }
            }
        }

        public int UpdateAnimal(Animal novosDados)
        {
            string update = "UPDATE tb_animalInfo SET nome=@nome, filo=@filo, classe=@classe, "
                        + "ordem=@ordem, familia=@familia, habitat=@habitat, estado_conservacao=@ec, "
                        + "descricao=@descricao WHERE foto=@foto;";
             
            int qtdRegistrosAfetados = 0;
            try
            {
                qtdRegistrosAfetados = SqlCommandNonQuery(update, novosDados);
            }
            catch
            {
                throw;
            }
            return qtdRegistrosAfetados;
        }

        public int AddAnimal(Animal animal)
        {
            string insert = "INSERT INTO tb_animalInfo(foto,nome,filo,classe," + 
                            "ordem,familia,habitat,estado_conservacao, descricao) "+
                            "VALUES (@foto,@nome,@filo,@classe,@ordem,@familia," +
                            "@habitat,@ec,@descricao);";

            int qtdRegistrosAfetados = 0;
            try
            {
                qtdRegistrosAfetados = SqlCommandNonQuery(insert, animal);
            }
            catch
            {
                throw;
            }
            return qtdRegistrosAfetados;
        }

        public int RemoveAnimal(Animal animalToDelete)
        {
            string delete = "DELETE FROM tb_animalInfo WHERE nome=@nome";

            int qtdRegistrosAfetados = 0;
            try
            {
                qtdRegistrosAfetados = SqlCommandNonQuery(delete, animalToDelete);
            }
            catch
            {
                throw;
            }
            return qtdRegistrosAfetados;
        }

        private int SqlCommandNonQuery(string comand, Animal animal)
        {
            using (SqlConnection conexao = new SqlConnection(conectionString))
            {
                using (SqlCommand comando = new SqlCommand(comand, conexao))
                {
                    conexao.Open();

                    comando.Parameters.Add("nome", System.Data.SqlDbType.NVarChar).Value = animal.nome;
                    comando.Parameters.Add("filo", System.Data.SqlDbType.NVarChar).Value = animal.filo;
                    comando.Parameters.Add("classe", System.Data.SqlDbType.NVarChar).Value = animal.classe;
                    comando.Parameters.Add("ordem", System.Data.SqlDbType.NVarChar).Value = animal.ordem;
                    comando.Parameters.Add("familia", System.Data.SqlDbType.NVarChar).Value = animal.familia;
                    comando.Parameters.Add("habitat", System.Data.SqlDbType.NVarChar).Value = animal.habitat;
                    comando.Parameters.Add("ec", System.Data.SqlDbType.NVarChar).Value = animal.estado_de_conservacao;
                    comando.Parameters.Add("descricao", System.Data.SqlDbType.NVarChar).Value = animal.descricao;
                    comando.Parameters.Add("foto", System.Data.SqlDbType.NVarChar).Value = animal.foto;

                    int qtdRegistrosAfetados = comando.ExecuteNonQuery();
                    conexao.Close();
                    return qtdRegistrosAfetados;
                }
            }
        }
    }
}
