using Bogus;
using Thunders_Borders.DTO.Internal;
using Thunders_Borders.Enums;

namespace Thunders_Tests.Builders
{
    public class CreateToDoListResponseBuilder
    {
        private ToDoListRequest instance;
        public Faker faker = new Faker();

        public CreateToDoListResponseBuilder()
        {
            instance = new ToDoListRequest()
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

        public ToDoListRequest Build() => instance;
    }
}
