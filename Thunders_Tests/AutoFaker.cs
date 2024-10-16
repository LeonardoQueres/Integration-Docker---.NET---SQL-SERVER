using Bogus;
using Thunders_Borders.Enums;

namespace Thunders_Tests
{
    public class AutoFaker<T> : Faker<T> where T : class
    {
        public AutoFaker() : base("pt_BR")
        {
            RuleForType(typeof(Guid), faker => faker.Random.Guid())
            .RuleForType(typeof(string), faker => faker.Random.Word())
            .RuleForType(typeof(int), faker => faker.Random.Int(1, 5))
            .RuleForType(typeof(DateTime), faker => faker.Date.Past())
            .RuleForType(typeof(PriorityType), faker => faker.PickRandom<PriorityType>())
            .RuleForType(typeof(StatusType), faker => faker.PickRandom<StatusType>());
        }
    }
}
