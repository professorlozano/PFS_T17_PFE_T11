using Atividade1.Interfaces;

namespace Atividade1.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {

        public string ?cpf { get; set; }
        public DateTime ?dataNascimento { get; set; }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }

        
    }
}