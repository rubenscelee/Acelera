using Cadastro_de_contatos.Models;

namespace Cadastro_de_contatos.Repository
{

    public interface IContatoRepository
    {
        List<ContatoModel> ListarContatos();

        ContatoModel Adicionar(ContatoModel contato);


    }
}
