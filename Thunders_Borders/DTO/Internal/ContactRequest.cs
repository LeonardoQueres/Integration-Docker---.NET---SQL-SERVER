using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thunders_Borders.DTO.Internal
{
    public class ContactRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Cep { get; set; }
    }
}
