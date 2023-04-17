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
            /*
                Rendimentos até 3000 vai pagar 3%
                Rendimentos de 3001 até 6000 vai pagar 5%
                Rendimentos de 6001 até 10000 vai pagar 7%
                Rendimentos acima de 10000 vai pagar 9%
            */
            float imposto;
            if(rendimento <= 3000)
            {
                imposto = rendimento * 0.03f;
                return imposto; 
            }
            else if(rendimento > 3000 && rendimento <= 6000)
            {
                imposto = rendimento * 0.05f;
                return imposto;
            }
            else if(rendimento > 6000 && rendimento <= 10000)
            {
                imposto = rendimento * 0.07f;
                return imposto;
            }
            else 
            {
                imposto = rendimento * 0.09f;
                return imposto;
            }
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