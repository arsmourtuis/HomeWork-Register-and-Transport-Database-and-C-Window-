using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Entidades
{
    public class TemporalE:ClasePersona
    {
        public TemporalE() { }


        // Atributos 
        private string _turno;

        //Constructores

        public TemporalE(string turno)
        {
            Turno = turno;
        }

        public TemporalE(string turno, int idE, string nombre, string apellidoP, string apellidoS, int cedula, double salario, string email, int celular, int seguro, string motor, string placa)
            : base(idE, nombre, apellidoP, apellidoS, cedula, salario, email, celular,seguro, motor, placa)
        
            {
            Turno = turno;
        }

        //GET y SET
        public string Turno { get => _turno; set => _turno = value; }

        // Override del método nombreCompleto de clasePersona para Doctor
        public override string DetalleCompleto()
        {
            return string.Format("IdE: {0} + Nombre: {1} + ApellidoP:  {2} + ApellidoS: {3} + Cedula: {4} + Salario: {5} + Correo: {6} + Celular: {7} + Seguro: {8} + Turno: {9} + Motor: {10} + Placa: {11}",
               IdE, Nombre, ApellidoP, ApellidoS, Cedula, Salario, Email, Celular, Seguro, Turno, Motor, Placa);
        }






    }
}
