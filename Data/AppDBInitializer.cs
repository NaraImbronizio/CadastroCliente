using CadastroCliente.Models;


namespace CadastroCliente.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder) 
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppCont>();
                context.Database.EnsureCreated();

                //Cadastrar Clientes
                if (context.Clientes.Any())
                {
                    context.Clientes.AddRange(new List<Cliente>()
                    {
                        new Cliente()
                        {
                            Name = "Alexandre Nicolas Thomas Viana",
                            Telefone = "(92) 99444-8040",
                            Email = "alexandre.nicolas.viana@ipmmi.org.br",
                            Logradouro = "Rua Marcílio Dias",
                            Numero = 782,
                           Complemento = "Apto 101",
                            Bairro = "Biribiri",
                            Cidade = "Manacapuru",
                            Estado = "AM",
                            Cep = "69400-083"
                        },
                        new Cliente() {
                            Name = "Henry Cauã Ribeiro",
                            Telefone = "(63) 99915-8506",
                            Email = "henry_caua_ribeiro@belbrindes.com",
                            Logradouro = "Avenida Tocantins 1164",
                            Numero = 431,
                            Complemento = " ",
                            Bairro = "Setor Central",
                            Cidade = "Araguaína",
                            Estado = "TO",
                            Cep = "77803-902"
                        },
                        new Cliente() {
                            Name = "Geraldo Kaique da Mota",
                            Telefone = "(67) 98217-8314",
                            Email = "geraldo.kaique.damota@dhl.com",
                            Logradouro = "Avenida Coronel Antonino 2530",
                            Numero = 553,
                            Complemento = " ",
                            Bairro = "Coronel Antonino",
                            Cidade = "Campo Grande",
                            Estado = "MS",
                            Cep = "79023-973"
                        },
                        new Cliente() {
                            Name = "Bryan Lucca Silva",
                            Telefone = "(96) 99252-1544",
                            Email = "bryan_lucca_silva@starmidia.tv",
                            Logradouro = "Avenida Pedro Baião",
                            Numero = 888,
                            Complemento = "Bloco A, Apto 25A",
                            Bairro = "Santa Rita",
                            Cidade = "Macapá",
                            Estado = "AP",
                            Cep = "68901-265"
                        },
                        new Cliente() {
                            Name = "Rita Josefa da Rosa",
                            Telefone = "(89) 98487-8417",
                            Email = "rita_darosa@badauy.com",
                            Logradouro = "Rua Tenente Domerval Alves Moreno",
                            Numero = 686,
                            Complemento = "Bloco D, Apto 17D",
                            Bairro = "Jardim Natal",
                            Cidade = "Picos",
                            Estado = "PI",
                            Cep = "64606-030"
                        },

                    });
                    context.SaveChanges();

                }
            }
        }
    }
}
