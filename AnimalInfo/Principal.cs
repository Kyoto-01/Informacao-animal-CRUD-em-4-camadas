using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using AnimalInfo.DTO;
using AnimalInfo.BLL;

namespace AnimalInfo
{
    public partial class Principal : Form
    {
        string tipoOperacaoConfirmacao = string.Empty;
        List<Animal> animais;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            try
            {
                this.Icon = new Icon(System.IO.Directory.GetCurrentDirectory() + "\\leopard.ico");
                SetAnimais();
                PreencherListBox();
                // para já deixar o 1° item da lista selecionado:
                lbx_animais.SelectedIndex = 0;
                MudarCorDoForm();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no carregamento de informações", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        } 

        private void SetAnimais()
        {
           animais = new AnimalInfo_BLL().buscarAnimais();
        }

        private void lbx_animais_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexItem = lbx_animais.SelectedIndex;

            if (indexItem >= 0)
            {
                txt_nome.Text = animais[indexItem].nome;
                txt_filo.Text = animais[indexItem].filo;
                txt_classe.Text = animais[indexItem].classe;
                txt_ordem.Text = animais[indexItem].ordem;
                txt_familia.Text = animais[indexItem].familia;
                txt_habitat.Text = animais[indexItem].habitat;
                txt_estado_conserv.Text = animais[indexItem].estado_de_conservacao;
                txt_descricao.Text = animais[indexItem].descricao;
                pic_animal.ImageLocation = "";

                if (animais[indexItem].foto != "")
                {
                    pic_animal.ImageLocation = (new AnimalInfo_BLL().enderecoFotos) + animais[indexItem].foto;
                }
                ResetarParaEstadoInicial();
            }
            MudarCorDoForm();
        }
      
        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (lbx_animais.SelectedItems.Count > 0)
            {
                tipoOperacaoConfirmacao = "edit";
                DesbolquearBloquearTextBoxes(false);
                btn_confirmar.Visible = true;
                btn_cancelar.Visible = true;
            }
            else
            {
                MessageBox.Show(new Menssagens().NoSelectEdit);
            }
            lbl_titulo.Select();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            tipoOperacaoConfirmacao = "add";
            lbx_animais.ClearSelected();
            EsvaziarTudo();
            DesbolquearBloquearTextBoxes(false);
            btn_foto.Visible = true;
            btn_confirmar.Visible = true;
            btn_cancelar.Visible = true;
            lbl_titulo.Select();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (lbx_animais.SelectedItems.Count > 0)
            {
                tipoOperacaoConfirmacao = "remove";
                btn_confirmar.Visible = true;
                btn_cancelar.Visible = true;
            }
            else
            {
                MessageBox.Show(new Menssagens().NoSelectDelete);
            }
            lbl_titulo.Select();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Predicate<Animal> criterios = AnimalJaRegistrado;
            Menssagens msgs = new Menssagens();

            if (animais.Exists(criterios))
            {
                MessageBox.Show(msgs.AnimalJaExiste);
                return;
            }

            int resultadoOperacao = Confirmacao();
            if (resultadoOperacao > 0)
            {
                ResetarParaEstadoInicial();
                MessageBox.Show(msgs.SucessoAtualizacao, "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                animais = new AnimalInfo_BLL().buscarAnimais();
                PreencherListBox();
                return;
            }
            else if (resultadoOperacao == 0)
            {
                MessageBox.Show(msgs.FalhaAtualizacao);
            }
        }

        private bool AnimalJaRegistrado(Animal animal)
        {
            // verifica se já existem um animal com o nome da textbox
            // se sim e o tipo da operação for add ou
            // se sim e o tipo da operação for edit e além disso,
            // o nome da figura for diferente do nome da textbox, é sinal que
            // aquele animal já existe no db e não estou apenas editando um animal
            // por isso retorna true

            return (animal.nome.ToUpper() == txt_nome.Text.Trim().ToUpper())
                    && (tipoOperacaoConfirmacao == "add" ||
                    tipoOperacaoConfirmacao == "edit" && txt_nome.Text.Trim().ToUpper() !=
                    System.IO.Path.GetFileNameWithoutExtension(pic_animal.ImageLocation).ToUpper());
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            ResetarParaEstadoInicial();
            if (lbx_animais.SelectedIndex < 0)
            {
                lbx_animais.SelectedIndex = 0;          
            }
        }

        private void btn_foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string extensao = System.IO.Path.GetExtension(fd.SafeFileName);
                if (extensao == ".jpg" || extensao == ".png")
                {
                    pic_animal.ImageLocation = fd.FileName;
                    return;
                }
                MessageBox.Show(new Menssagens().ErroFormatoImagem, "Formato de arquivo não aceito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            lbl_titulo.Select();
        }

        private int Confirmacao()
        {
            int resposta = 0;
            Animal animalObject = new Animal();

            PreencherAnimalObject(animalObject);
            switch (tipoOperacaoConfirmacao)
            {
                case "edit":
                    resposta = ConfirmacaoEdit(animalObject);
                    break;
                case "add":
                    resposta = ConfirmacaoAdd(animalObject);
                    break;
                case "remove":
                    resposta = ConfirmacaoRemove(animalObject);
                    break;
            }
            return resposta;
        }

        private int ConfirmacaoEdit(Animal animalObject)
        {
            int resposta = 0;
            string nomeAnimal = animalObject.nome;
            if (nomeAnimal != "")
            {
                if (animalObject.descricao.Length <= 500)
                {
                    resposta = new AnimalInfo_BLL().EditarAnimal(animalObject);
                }
                else
                {
                    resposta = -1;
                    MessageBox.Show(new Menssagens().DescricaoGrandeDemais, "Descrição muito grande", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            return resposta;
        }

        private int ConfirmacaoAdd(Animal animalObject)
        {
            int resposta = 0;
           
            if (animalObject.nome != "" && pic_animal.ImageLocation != "")
            {
               CopiarColarFoto(animalObject.foto);
               resposta = new AnimalInfo_BLL().AddAnimal(animalObject);
            }
            return resposta;
        }

        private int ConfirmacaoRemove(Animal animalObject)
        {
            int resposta = 0;

            resposta = new AnimalInfo_BLL().RemoveAnimal(animalObject);
            System.IO.File.Delete(new AnimalInfo_BLL().enderecoFotos + "/" + animalObject.foto);
            EsvaziarTudo();

            return resposta;
        }

        public void CopiarColarFoto(string nomeParaFoto)
        {
            string destino = new AnimalInfo_BLL().enderecoFotos + "/" + nomeParaFoto;
            string fonte = pic_animal.ImageLocation;
            System.IO.File.Copy(fonte, destino, false);
        }

        private void ResetarParaEstadoInicial()
        {
            tipoOperacaoConfirmacao = "";
            btn_foto.Visible = false;
            btn_confirmar.Visible = false;
            btn_cancelar.Visible = false;
            DesbolquearBloquearTextBoxes(true);
            lbl_titulo.Select();
        }

        private void PreencherListBox()
        {
            lbx_animais.Items.Clear();
            foreach (Animal animal in animais)
            {
                lbx_animais.Items.Add(animal.nome);
            }
        }

        private void MudarCorDoForm()
        {
            Random rgbAleatorios = new Random();
            int r = rgbAleatorios.Next(120, 255);
            int g = rgbAleatorios.Next(120, 255);
            int b = rgbAleatorios.Next(120, 255);

            this.BackColor = Color.FromArgb(255, r, g, b);
        }

        private void DesbolquearBloquearTextBoxes(bool readOnly_estado)
        {
            txt_nome.ReadOnly = readOnly_estado;
            txt_filo.ReadOnly = readOnly_estado;
            txt_classe.ReadOnly = readOnly_estado;
            txt_ordem.ReadOnly = readOnly_estado;
            txt_familia.ReadOnly = readOnly_estado;
            txt_habitat.ReadOnly = readOnly_estado;
            txt_estado_conserv.ReadOnly = readOnly_estado;
            txt_descricao.ReadOnly = readOnly_estado;
        }

        private void EsvaziarTudo()
        {
            txt_nome.Text = "";
            txt_filo.Text = "";
            txt_classe.Text = "";
            txt_ordem.Text = "";
            txt_familia.Text = "";
            txt_habitat.Text = "";
            txt_estado_conserv.Text = "";
            txt_descricao.Text = "";
            pic_animal.ImageLocation = "";
        }

        private void PreencherAnimalObject(Animal atualizado)
        {
            atualizado.nome = txt_nome.Text.Trim();
            atualizado.filo = txt_filo.Text.Trim();
            atualizado.classe = txt_classe.Text.Trim();
            atualizado.ordem = txt_ordem.Text.Trim();
            atualizado.familia = txt_familia.Text.Trim();
            atualizado.habitat = txt_habitat.Text.Trim();
            atualizado.estado_de_conservacao = txt_estado_conserv.Text.Trim();
            atualizado.descricao = txt_descricao.Text.Trim();
            if (tipoOperacaoConfirmacao == "add")
            {
                atualizado.foto = atualizado.nome + System.IO.Path.GetExtension(pic_animal.ImageLocation);
                return;
            }
            atualizado.foto = System.IO.Path.GetFileName(pic_animal.ImageLocation);
        }
    }
}
