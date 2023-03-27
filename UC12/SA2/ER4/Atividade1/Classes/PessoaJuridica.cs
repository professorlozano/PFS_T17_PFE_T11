using Atividade1.Interfaces;
using System.Text.RegularExpressions;

namespace Atividade1.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string ?cnpj { get; set; }
        public string ?razaoSocial { get; set; }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {

            /*
                XX.XXX.XXX/0001-XX
                @"\d{2}.\d{3}.\d{3}/\d{4}-\d{2}"
                XXXXXXXX0001XX
                \d{14}


            */
            if(Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if(cnpj.Length == 18)
                {
                    if(cnpj.Substring(11,4) == "0001") //ele vai iniciar no caractere 11 e vai pegar 4 caracteres XX.XXX.XXX/0001-XX 
                    {
                        return true;
                    }   
                }
                else if(cnpj.Length == 14)
                {
                    if(cnpj.Substring(8,4) == "0001")
                    {
                        return true;
                    }  
                }    
            }

            return false;
        }
    }
}