using Atividade1.Interfaces;

namespace Atividade1.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {

        public string ?cpf { get; set; }
        public string ?dataNascimento { get; set; }

        public override float PagarImposto(float rendimento)
        {
            /*
                Rendimento até 1500 isento
                Rendimento de 1501 até 3500 vai pagar 2%
                Rendimento de 3501 até 6000 vai pagar 3,5%
                Rendimento acima de 6000 vai pagar 5%

                revisão de operadores
                Tabela Verdade E (&&)
                V && V = V
                V && F = F
                F && V = F
                F && F = F 
                Posso dizer que, na tabela verdade do operador E (&&), apenas terei resposta verdadeira
                se ambas as proposições analisadas forem verdadeiras.

                Tabela Verdade OU (||)
                V || V = V
                V || F = V
                F || V = V
                F || F = F
                Posso dizer que, na tabela verdade do operador OU (||), apenas terei resposta falsa
                se ambas as proposições analisadas forem falsas.

                Negação NOT (!)
                Basta negar uma sentença pra que seu resultado vire o oposto.

            */
            if (rendimento <= 1500)
            {
                return 0; // isento, imposto 0.
            }
            else if(rendimento > 1500 && rendimento <= 3500)
            {
                //imposto de 2%
                return (rendimento / 100)* 2;
            }
            else if(rendimento > 3500 && rendimento <= 6000)
            {
                return (rendimento / 100) * 3.5f;
            }
            else
            {
                return (rendimento / 100) * 5;
            }
        }

        /*
        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataNasc).TotalDays / 365; //TotalDays converte para dias
            //Console.WriteLine($"{anos}");
            if(anos >= 18){
                return true;
            }
            return false; //não precisa do else pq caso seja verdadeira o primeiro return ja conclui a sentença
        }
        */
        public bool ValidarDataNascimento(string dataNasc)
        {
            DateTime dataConvertida;
            //verificar se a string esta em um formato valido
            if(DateTime.TryParse(dataNasc, out dataConvertida)){//try parse tenta converter e coloca na saida
                //Console.WriteLine($"{dataConvertida}");
                DateTime dataAtual = DateTime.Today;
                double anos = (dataAtual - dataConvertida).TotalDays / 365; //TotalDays converte para dias
                if(anos >= 18){
                    return true;
                }
                return false; //não precisa do else pq caso seja verdadeira o primeiro return ja conclui a sentença
            }
            return false;
        }
    }
}