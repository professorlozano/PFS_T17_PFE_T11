
using Atividade1.Classes;

/*
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
*/

/*
Console.WriteLine($"Nome: {novaPf.nome}");
Console.WriteLine($"Data de Nascimento: {novaPf.dataNascimento}");
Console.WriteLine($"Cpf: {novaPf.cpf}");
Console.WriteLine($"Rendimento: {novaPf.rendimento}");
Console.WriteLine($"Logradouro: {novaPf.endereco.logradouro}");
Console.WriteLine($"Numero: {novaPf.endereco.numero}");
Console.WriteLine($"Complemento: {novaPf.endereco.complemento}");
Console.WriteLine($"Endereço Comercial? {novaPf.endereco.endComercial}");
Console.WriteLine($"Maior de Idade? {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}");
*/


/*
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

*/

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

//Console.WriteLine($"{metodoPj.ValidarCnpj("00.000.000/0002-00")}");
//Console.WriteLine($"{metodoPj.ValidarCnpj("00000000000100")}");














//Console.WriteLine(novaPf.ValidarDataNascimento("01-01-2010"));







