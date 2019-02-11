using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Core.Entities;
using Infraestructura.Data.MySQL;
namespace Dominio.MainModule
{
    public class PruebaManager
    {
        Prueba objDAL = new Prueba();
        public IEnumerable<Pruebas> listaPrueba()
        {
            return objDAL.listaPrueba();
        }

    }
}
