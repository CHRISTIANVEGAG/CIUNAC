using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Dominio.Core.Entities
{
    public class Pruebas
    {
        [DisplayName("CODIGO")]
        public int codigo { get; set; }

        [DisplayName("NOMBRE")]
        public string nombre { get; set; }

    }
}
