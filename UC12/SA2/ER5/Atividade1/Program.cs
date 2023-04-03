
using Atividade1.Classes;

Console.WriteLine(@$"
===================================================================
|              Bem Vindo ao Sistema de Cadastro de                |
|                  Pessoas Físicas e Jurídicas                    |
===================================================================
");

BarraCarregamento("Carregando ", 300);

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
        PessoaFisica novaPf = new PessoaFisica();
        Endereco novoEnd = new Endereco();
        PessoaFisica metodoPf = new PessoaFisica();

        novaPf.nome = "Lozano";
        novaPf.dataNascimento = "18/02/1984";
        novaPf.cpf = "12345678900";
        novaPf.rendimento = 1500;

        novoEnd.logradouro = "Rua Niteroi";
        novoEnd.numero = 180;
        novoEnd.complemento = "Escola Senai de Informática";
        novoEnd.endComercial = true;

        novaPf.endereco = novoEnd;

        Console.Clear();

        Console.WriteLine(@$"
            Nome: {novaPf.nome}
            Data de Nascimento: {novaPf.dataNascimento}
            Cpf: {novaPf.cpf}
            Rendimento: {novaPf.rendimento}
            Logradouro: {novaPf.endereco.logradouro}
            Numero: {novaPf.endereco.numero}
            Complemento: {novaPf.endereco.complemento}
            Endereço Comercial? {novaPf.endereco.endComercial}
            Maior de idade? {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}
            ");

            Console.WriteLine($"Aperte 'Enter' para continuar...");
            Console.ReadLine();
            
        break;
    case "2":
        PessoaJuridica metodoPj = new PessoaJuridica();
        PessoaJuridica novaPj = new PessoaJuridica();
        Endereco novoEndPj = new Endereco();

        novaPj.nome = "Nome PJ";
        novaPj.cnpj = "00.000.000/0001-00";
        novaPj.razaoSocial = "Razao Social PJ";
        novaPj.rendimento = 5000;

        novoEndPj.logradouro = "Rua Goitacazez";
        novoEndPj.numero = 300;
        novoEndPj.complemento = "Esquina com a Niteroi";
        novoEndPj.endComercial = true;

        novaPj.endereco = novoEndPj;

        Console.Clear();

        Console.WriteLine(@$"
            Nome: {novaPj.nome}
            CNPJ: {novaPj.cnpj}
            Razao Social: {novaPj.razaoSocial}
            Rendimento: {novaPj.rendimento}
            Logradouro: {novaPj.endereco.logradouro}
            Numero: {novaPj.endereco.numero}
            Complemento: {novaPj.endereco.complemento}
            Endereço Comercial? {novaPj.endereco.endComercial}
            CNPJ é valido? {metodoPj.ValidarCnpj(novaPj.cnpj)}
            ");
            Console.WriteLine($"Aperte 'Enter' para continuar...");
            Console.ReadLine();
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







