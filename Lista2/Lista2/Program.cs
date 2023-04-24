using Lista2;

Pessoa pessoa = new Pessoa()
{
    Nome = "jessica",
    Idade = 25,
    Altura = 1.55f,
    Peso = 39f,
};

Carro carro = new Carro()
{
    Marca = "xefroleh",
    Modelo = "classic",
    Cor = "verde",
    Ano = 2001

};

List<Pessoa> lstPessoa = new List<Pessoa>();
List<Carro> lstCarro = new List<Carro>();


lstPessoa.Add(pessoa);
lstCarro.Add(carro);

lstPessoa.ForEach(pessoa => Console.WriteLine(pessoa));
lstCarro.ForEach(carro => Console.WriteLine(carro));