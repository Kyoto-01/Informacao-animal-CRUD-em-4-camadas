namespace AnimalInfo.DTO
{
    public class Menssagens
    {
        public string noSelectEdit = "Selecione um item antes de tentar editar.";
        private string noSelectDelete = "Selecione um item antes de tentar excluir.";
        private string sucessoAtualizacao = "Dados atualizados com sucesso!";
        private string falhaAtualizacao = "Ocorreu um erro ao atualizar os dados. \nLEMBRE-SE: [O campo \"Nome\" não pode estar vazio]," +
                                          " [O campo da foto não pode estar vazio]";
        private string animalJaExiste = "Já existe um animal registrado com este nome.";
        private string erroFormatoImagem = "Apenas são aceitos arquivos no formato .JPG ou .PNG!";
        private string descricaoGrandeDemais = "A descrição deve conter no máximo 500 caracteres.";

        public string NoSelectEdit { get { return noSelectEdit; } }
        public string NoSelectDelete { get { return noSelectDelete; } }
        public string SucessoAtualizacao { get { return sucessoAtualizacao; } }
        public string FalhaAtualizacao { get { return falhaAtualizacao; } }
        public string AnimalJaExiste { get { return animalJaExiste; } }
        public string ErroFormatoImagem { get { return erroFormatoImagem; } }
        public string DescricaoGrandeDemais { get { return descricaoGrandeDemais; } }
    }
}
