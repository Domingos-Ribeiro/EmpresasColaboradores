using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpresasColaboradores.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Localidade { get; set; }

        public virtual ICollection<Colaborador> Colaboradores { get; set; }
    }
}