using Bogus;
using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thunders_Borders.DTO.Internal;
using Thunders_Borders.Entities;
using Thunders_Borders.Enums;

namespace Thunders_Tests.Builders
{
    public class ToDoListBuilder
    {
        private readonly ToDoList instance;
        public Faker faker = new Faker();

        public ToDoListBuilder()
        {
            instance = new ToDoList()
            {
                Tarefa = faker.Random.String(),
                Descricao = faker.Random.String(),
                Observacoes = faker.Random.String(),
                Prioridade = PriorityType.Alta,
                Responsavel = faker.Random.String(),
                Status = StatusType.Pendente,
                Vencimento = DateTime.Now.AddDays(30)
            };
        }

        public ToDoList Build() => instance;
    }
}
