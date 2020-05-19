using System;
using System.Collections.Generic;
using AnimalInfo.DAL;
using AnimalInfo.DTO;

namespace AnimalInfo.BLL
{
    public class AnimalInfo_BLL
    {
        public string enderecoFotos
        {
            get { return System.IO.Directory.GetCurrentDirectory() + "\\fotos\\"; }
        }

        public List<Animal> buscarAnimais()
        {
            try
            {
                return new AnimalInfo_DAL().BuscarAnimais();
            }
            catch
            {
                throw;
            }
        }

        public int EditarAnimal(Animal animalEditado)
        {
            try
            {
                if (animalEditado.nome != "")
                {
                    if (animalEditado.descricao.Length <= 500)
                    {
                        return new AnimalInfo_DAL().UpdateAnimal(animalEditado);
                    }
                    return -1; //descrição muito grande
                }
                return 0; //Falta escrever nome do animal
            }
            catch
            {
                throw;
            }
        }

        public int AddAnimal(Animal novoAnimal, string ImageLocationPictureBox)
        {
            try
            {
                if (novoAnimal.nome != "" && ImageLocationPictureBox != "")
                {
                    return new AnimalInfo_DAL().AddAnimal(novoAnimal);
                }
                return -1;
            }
            catch
            {
                throw;
            }
        }

        public int RemoveAnimal(Animal animalToRemove)
        {
            try
            {
                return new AnimalInfo_DAL().RemoveAnimal(animalToRemove);
            }
            catch
            {
                throw;
            }
        }

        public bool VerificarSeAnimalJaRegistrado(Animal animal, string textBox_nome, string tipoOperacao, string pictureBox_imgLocation)
        {
            // verifica se já existe um animal com o nome de textBox_nome
            // se sim e tipoOperação for add ou
            // se sim e tipoOperação for edit e além disso,
            // o arquivo sem extensão de pictureBox_imgLocation 
            // for diferente de textBox_nome, é sinal que
            // aquele animal já existe no db e não estou apenas editando um animal
            // por isso retorna true

            return (animal.nome.ToUpper() == textBox_nome.Trim().ToUpper())
                    && (tipoOperacao == "add" ||
                    tipoOperacao == "edit" && textBox_nome.Trim().ToUpper() !=
                    System.IO.Path.GetFileNameWithoutExtension(pictureBox_imgLocation).ToUpper());
        }
    }
}
