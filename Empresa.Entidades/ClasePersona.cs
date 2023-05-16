using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Entidades
{
    public class ClasePersona
    {
        //Atributos
        private int _idE;
        private string _nombre;
        private string _apellidoP;
        private string _apellidoS;
        private int _cedula;
        private double _salario;
        private string _email;
        private int _celular;
        private int _seguro; 
        private string _motor;
        private string _placa;

        //Constructores
        public ClasePersona()
        {
        }

        public ClasePersona(int idE, string nombre, string apellidoP, string apellidoS, int cedula, double salario, string email, int celular, int seguro, string motor,string placa)
        {
            IdE = idE;
            Nombre = nombre;
            ApellidoP = apellidoP;
            ApellidoS = apellidoS;
            Cedula = cedula;
            Salario = salario;
            Email = email;
            Celular = celular;
            Seguro = seguro;
            Motor = motor;
            Placa = placa;

        }

        //GET y SET
        public int IdE { get => _idE; set => _idE = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string ApellidoP { get => _apellidoP; set => _apellidoP = value; }
        public string ApellidoS { get => _apellidoS; set => _apellidoS = value; }
        public int Cedula { get => _cedula; set => _cedula = value; }
        public double Salario { get => _salario; set => _salario = value; }
        public int Celular { get => _celular; set => _celular = value; }
        public string Email { get => _email; set => _email = value; }
        public int Seguro { get => _seguro; set => _seguro = value; }
        
        public string Motor { get => _motor; set => _motor = value; }

        public string Placa { get => _placa; set => _placa = value; }

        //método nombreCompleto que se sobreescribirá con EmpleadoTurno
        public virtual string DetalleCompleto()
        {
            return string.Format("IdE: " + _idE + "Nombre: " + _nombre + " ApellidoP " + _apellidoP + " ApellidoS " +
                _apellidoS + " Cédula: " + _cedula + "Salario: " + _salario + "Email: " + _email + "Celular: " + _celular + "Seguro: " + _seguro + "Motor " + _motor + "Placa " + _placa);
        }
    }
}
