using System;
using System.Collections.Generic; //coleção genérica, relacionada a herança

namespace ExemploLista
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<string> cidades = new List<string>(); //a lista assume dinamicamente que o dado que vamos imputar é do tipo string
            // cidades.Add("São Paulo"); //adicionando itens à lista
            // cidades.Add("Curitiba");
            // cidades.Add("Osasco");
            // cidades.Add("Manaus");

            // Console.WriteLine(cidades[1].ToUpper());


            // ---------------------------------

            // List<Usuarios> us = new List<Usuarios>(); //nova lista
            // Usuarios lucas = new Usuarios(){ //criando os objetos lucas e tuanny
            //     Id=35,Login="lucas",Senha="12345"};
            // Usuarios tuanny = new Usuarios(){
            //     Id=10,Login="lucas",Senha="12"};

            // us.Add(lucas); //adicionando os objetos na lista
            // us.Add(tuanny);

            // Console.WriteLine(us[0].Login); //puxando o dado do login pela posição

            // ---------------------------------

            List<Produto> sacola = new List<Produto>(); //estamos instanciando a lista pai e não o objeto
            
            HigienePessoal sabonete = new HigienePessoal();
            sabonete.Id = 10;
            sabonete.Nome = "Dove";

            Bebidas cerveja = new Bebidas();
            cerveja.Id = 15;
            cerveja.Nome = "Skol";

            sacola.Add(sabonete);
            sacola.Add(cerveja);
           
            foreach (var item in sacola){ //vai percorrer o item da sacola
                
                string classe = item.GetType().ToString(); //preciso saber de é do tipo higiene pessoal ou bebidas. gettype retorna o tipo.

                switch (classe){ //caso seja higiene pessoal fazemos uma ação e se for bebidas vamos agir de outr

                    case "ExemploLista.HigienePessoal":
                    {
                        HigienePessoal higiene = (HigienePessoal)item; //conversão do produto para higiene pessoal, do genérico para o mais específico. Assim aparece a os atributos da classe filha.
                        Console.WriteLine("Higiene Pessoal: "+higiene.Nome+" - "+higiene.NumeroMS+" - "+higiene.Marca);

                        break;
                    }

                    case "ExemploLista.Bebidas":
                    {
                        Bebidas bebidas = (Bebidas)item;
                        Console.WriteLine("Bebidas: "+bebidas.Nome+" - "+bebidas.TeorAlcoolico+" - "+bebidas.Tipo);

                        break;
                    }

                }

            }

        }
    }
}
