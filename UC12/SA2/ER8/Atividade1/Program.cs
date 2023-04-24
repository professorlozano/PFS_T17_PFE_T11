
using Atividade1.Classes;

Console.Clear();
Console.WriteLine(@$"
===================================================================
|              Bem Vindo ao Sistema de Cadastro de                |
|                  Pessoas Físicas e Jurídicas                    |
===================================================================
");

BarraCarregamento("Carregando ", 300);

List<PessoaFisica> listaPf = new List<PessoaFisica>();

string? opcao;

do
{
    
Console.Clear();

Console.WriteLine(@$"
===================================================================
|                 Escolha uma das opções abaixo                   |
|-----------------------------------------------------------------|
|                      1 - Pessoa Física                          |
|                      2 - Pessoa Jurídica                        |
|                                                                 |
|                      0 - Sair                                   |
===================================================================
");

opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
        PessoaFisica metodoPf = new PessoaFisica();

        string? opcaoPf;
        do
        {
            Console.Clear();
            Console.WriteLine(@$"
===================================================================
|                 Escolha uma das opções abaixo                   |
|-----------------------------------------------------------------|
|                      1 - Cadastrar Pessoa Física                |
|                      2 - Mostrar Pessoas Físicas                |
|                                                                 |
|                      0 - Voltar ao menu anterior                |
===================================================================
");
            opcaoPf = Console.ReadLine();

            switch (opcaoPf)
            {
                case "1":
                    Console.Clear();
                    PessoaFisica novaPf = new PessoaFisica();
                    Endereco novoEnd = new Endereco();
                    
                    Console.WriteLine($"Digite o nome da Pessoa Física que deseja cadastrar");
                    novaPf.nome = Console.ReadLine();

                    
                    bool dataValida;
                
                    do
                    {
                        Console.WriteLine($"Digite a data de Nascimento Ex.: DD/MM/AAAA");
                        string dataNasc = Console.ReadLine();

                        dataValida = metodoPf.ValidarDataNascimento(dataNasc);
                        if (dataValida)
                        {
                            novaPf.dataNascimento = dataNasc;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"Data digitada inválida, por favor digite uma data válida"); 
                            Console.ResetColor(); 
                        }
                        
                    } while (dataValida == false);

                    /*
                    Console.WriteLine($"Digite o número do CPF: ");
                    novaPf.cpf = Console.ReadLine();

                    Console.WriteLine($"Digite o rendimento mensal (digite apenas números)");
                    novaPf.rendimento = float.Parse(Console.ReadLine());

                    Console.WriteLine($"Digite o logradouro");
                    novoEnd.logradouro = Console.ReadLine();

                    Console.WriteLine($"Digite o número");
                    novoEnd.numero = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Digite o complemento (aperte ENTER para vazio)");
                    novoEnd.complemento = Console.ReadLine();
                    
                    Console.WriteLine($"Este endereço é comercial? S ou N");
                    string endCom = Console.ReadLine().ToUpper();

                    if (endCom == "S")
                    {
                         novoEnd.endComercial = true;
                    }
                    else
                    {
                         novoEnd.endComercial = false;
                    }
                    novaPf.endereco = novoEnd;
                    //listaPf.Add(novaPf);
                    */

                    using (StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt"))
                    {
                        sw.WriteLine(novaPf.nome);
                        sw.WriteLine(novaPf.dataNascimento);
                    }


                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Cadastro Realizado com Sucesso!!!");
                    Thread.Sleep(3000);
                    Console.ResetColor();
                    //Console.Clear();
                    break;
                case "2":
                    Console.Clear();

                    /*
                    if (listaPf.Count > 0)
                    {
                        foreach (PessoaFisica cadaPessoa in listaPf)
                        {
                            Console.Clear();
                            Console.WriteLine(@$"
                                Nome: {cadaPessoa.nome}
                                Data de Nascimento: {cadaPessoa.dataNascimento}
                                Cpf: {cadaPessoa.cpf}
                                Rendimento: {(cadaPessoa.rendimento).ToString("C")}
                                Logradouro: {cadaPessoa.endereco.logradouro}
                                Numero: {cadaPessoa.endereco.numero}
                                Complemento: {cadaPessoa.endereco.complemento}
                                Endereço Comercial? {((bool)cadaPessoa.endereco.endComercial?"Sim":"Não")}
                                Maior de idade? {(metodoPf.ValidarDataNascimento(cadaPessoa.dataNascimento) ? "Sim": "Não")}
                                Taxa de Imposto a ser paga é: {metodoPf.PagarImposto(cadaPessoa.rendimento).ToString("C")}
                            ");

                            Console.WriteLine($"Aperte 'Enter' para continuar...");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Lista Vazia!!!");
                        Thread.Sleep(3000);
                    }
                    */

                    using (StreamReader sr = new StreamReader($"Luiz.txt"))
                    {
                        string linha;
                        while((linha = sr.ReadLine())!= null){
                            Console.WriteLine($"{linha}"); 
                        }
                    }
                    Console.WriteLine($"Aperte 'Enter'para continuar...");
                    Console.ReadLine();
                    break;
                case "0":
                    //a opção 0 retorna ao menu anterior, não vou inserir nenhuma mensagem.
                    break;
                default:
                    break;
            }
            
            
        } while (opcaoPf != "0");
            
        break;
    case "2":
        PessoaJuridica metodoPj = new PessoaJuridica();

        PessoaJuridica novaPj = new PessoaJuridica();
        Endereco novoEndPj = new Endereco();

        novaPj.nome = "Eletro Tec Informatica";
        novaPj.cnpj = "02.001.001/0003-30";
        novaPj.razaoSocial = "Eletro Tec Me Comercio de Coisas";
        novaPj.rendimento = 5000;

        novoEndPj.logradouro = "Rua Goitacazez";
        novoEndPj.numero = 300;
        novoEndPj.complemento = "Esquina com a Niteroi";
        novoEndPj.endComercial = false;

        novaPj.endereco = novoEndPj;

        metodoPj.Inserir(novaPj);

        List<PessoaJuridica> listaPj = metodoPj.Ler();

        foreach (PessoaJuridica cadaItem in listaPj)
        {
            Console.Clear();
            Console.WriteLine(@$"
            Nome: {novaPj.nome}
            CNPJ: {novaPj.cnpj}
            Razao Social: {novaPj.razaoSocial}
            ");

            Console.WriteLine($"Aperte 'Enter' para continuar...");
            Console.ReadLine();
        }

        /*
        Console.Clear();

        Console.WriteLine(@$"
            Nome: {novaPj.nome}
            CNPJ: {novaPj.cnpj}
            Razao Social: {novaPj.razaoSocial}
            Rendimento: {(novaPj.rendimento).ToString("C")}
            Logradouro: {novaPj.endereco.logradouro}
            Numero: {novaPj.endereco.numero}
            Complemento: {novaPj.endereco.complemento}
            Endereço Comercial? {((bool)novaPj.endereco.endComercial?"Sim":"Não")}
            CNPJ é valido? {(metodoPj.ValidarCnpj(novaPj.cnpj)?"Sim":"Não")}
            Taxa de Imposto a ser paga é: {metodoPj.PagarImposto(novaPj.rendimento).ToString("C")}
            ");
            Console.WriteLine($"Aperte 'Enter' para continuar...");
            Console.ReadLine();
            */


        break;
    case "0":
        BarraCarregamento("Finalizando ", 300);
        break;
    default:
        Console.Clear();
        Console.WriteLine($"Opção Inválida, por favor digite outra opção.");
        Thread.Sleep(2000);
        break;
}
} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo){
        Console.BackgroundColor = ConsoleColor.DarkCyan;
        Console.ForegroundColor = ConsoleColor.Red;

        Console.Write($"{texto}");

        for (var contador = 0; contador < 27; contador ++)
        {
            Console.Write(". ");
            Thread.Sleep(tempo);
        }

        Console.ResetColor();
}







