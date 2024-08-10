using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public abstract class Vehiculo : IEntity
    {
        public int Id {  get; set; }
        public abstract decimal CalcularIncremento(decimal pTotal, int pHoras);
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }
        public Dueño Dueño { get; set; }
    }
    public class Auto : Vehiculo
    {
        public Auto(string pMarca, string pModelo, string pPatente, Dueño pDueño)
        {
            this.Marca = pMarca; this.Modelo = pModelo; this.Patente = pPatente;
            this.Dueño = pDueño; 
        }
        public override decimal CalcularIncremento(decimal pTotal, int pHoras)
        {
            throw new NotImplementedException();
        }
    }
    public class Moto : Vehiculo
    {
        public Moto(string pMarca, string pModelo, string pPatente, Dueño pDueño)
        {
            this.Marca = pMarca; this.Modelo = pModelo; this.Patente = pPatente;
            this.Dueño = pDueño;
        }
        public override decimal CalcularIncremento(decimal pTotal, int pHoras)
        {
            throw new NotImplementedException();
        }
    }
}
