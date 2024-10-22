using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thunders_Borders.Entities;
using Thunders_Borders.Enums;

namespace Thunders_Repositories.DataContext.Configurations
{
    public class ContatosConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasData(
                            new Contact
                            {
                                Id = Guid.Parse("a5dd3e54-c21e-4aa2-81b6-a18854983ecf"),
                                Name = "Teste 1",
                                Email = "teste@teste.com",
                                Endereco = "Teste 1 numero 1",
                                Bairro = "teste bairro",
                                Cidade = "teste cidade",
                                Estado = "RL",
                                Telefone = 12342134,
                                Cep = 12345213
                            },
                            new Contact
                            {
                                Id = Guid.Parse("2c746303-acff-4815-988e-df1e167a462a"),
                                Name = "Teste 2",
                                Email = "atestado@teste.com",
                                Endereco = "Teste 2 numero 2",
                                Bairro = "atestado bairro",
                                Cidade = "atestado cidade",
                                Estado = "ML",
                                Telefone = 90987890,
                                Cep = 98765789
                            }
                        );
        }
    }
}
