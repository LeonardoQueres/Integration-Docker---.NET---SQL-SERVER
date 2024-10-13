using Bogus;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thunders_Borders.DTO.Internal;
using Thunders_Borders.Enums;

namespace Thunders_Tests.Builders
{
    public class CreateToDoListRequestBuilder
    {
        private ToDoListRequest instance;
        public Faker faker = new Faker();

        public CreateToDoListRequestBuilder()
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

        public CreateToDoListRequestBuilder WithTarefa(string tarefa)
        {
            instance = instance with { Tarefa = tarefa };
            return this;
        }
        public CreateToDoListRequestBuilder WithDescricao(string descricao)
        {
            instance = instance with { Descricao = descricao };
            return this;
        }
        public CreateToDoListRequestBuilder WithResponsavel(string resp)
        {
            instance = instance with { Responsavel = resp };
            return this;
        }
        public CreateToDoListRequestBuilder WithObservacao(string obs)
        {
            instance = instance with { Observacoes = obs };
            return this;
        }

        public CreateToDoListRequestBuilder WithVencimento(DateTime date)
        {
            instance = instance with { Vencimento = date };
            return this;
        }

        public CreateToDoListRequestBuilder WithPriorityType(PriorityType prioridade)
        {
            instance = instance with { Prioridade = prioridade };
            return this;
        }

        public CreateToDoListRequestBuilder WithStatusType(StatusType status)
        {
            instance = instance with { Status = status };
            return this;
        }

        public ToDoListRequest Build() => instance;
    }
}
