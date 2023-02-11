using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bbdd
{
    public class Class1
    {
        public void Ejecutar()
        {
            using (var context = new Models.SampleContext2())
            {
                var aux = context.tipo_vehiculo.ToList();
            }
        }
    }
}
