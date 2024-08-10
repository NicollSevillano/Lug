using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace BEL
{
    public class Factura : IEntity
    {
        public int Id {  get; set; }
        public Dueño Dueño { get; set; }
        public List<Vehiculo> VehiculoListFactura { get; set; }
        public DateTime Fecha_ingreso { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public decimal Total {  get; set; }
    }
}
