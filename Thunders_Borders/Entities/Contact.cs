#nullable disable warnings
using System.Text.Json.Serialization;
using Thunders_Borders.DTO.Internal;

namespace Thunders_Borders.Entities
{
    public class Contact
    {
        public Contact(ContactRequest contato) : this()
        {
            Name = contato.Name;
            Email = contato.Email;
            Telefone = contato.Telefone;
            Endereco = contato.Endereco;
            Bairro = contato.Bairro;
            Cidade = contato.Cidade;
            Estado = contato.Estado;
            Cep = contato.Cep;
        }
        public Contact() => Id = Guid.NewGuid();

        [JsonInclude]
        public Guid Id { get; init; }
        [JsonInclude]
        public string Name { get; set; }
        [JsonInclude]
        public string Email { get; set; }
        [JsonInclude]
        public int Telefone { get; set; }
        [JsonInclude]
        public string Endereco { get; set; }
        [JsonInclude]
        public string Bairro { get; set; }
        [JsonInclude]
        public string Cidade { get; set; }
        [JsonInclude]
        public string Estado { get; set; }
        [JsonInclude]
        public int Cep { get; set; }
    }
}
