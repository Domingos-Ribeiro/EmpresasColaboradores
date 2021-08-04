using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpresasColaboradores.Models
{
    public class Colaborador
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public int EmpresaId { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}