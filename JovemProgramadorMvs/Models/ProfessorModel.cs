using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JovemProgramadorMvs.Models
{
    public class ProfessorModel
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string cep { get; set; }

    }
}