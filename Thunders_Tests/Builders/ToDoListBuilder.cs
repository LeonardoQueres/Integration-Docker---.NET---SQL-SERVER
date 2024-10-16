using Bogus;
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
