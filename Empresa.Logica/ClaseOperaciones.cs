using System;
using System.Collections.Generic;
using System.Linq;
using Empresa.Entidades;

namespace Empresa.LogicaNegocios
{
    public class ClaseOperaciones
    {
        // Declarar listas
        List<Entidades.ClaseOperaciones> listaEmpleadoDiurno = new List<Entidades.ClaseOperaciones>();
        List<ClaseEmpleadoN> listaEmpleadoNocturno = new List<ClaseEmpleadoN>();

        // inserta nuevo empleadoDiurno en listaEmpleadoDiurno
        public void InsertarEmpleadoDiurno(Entidades.ClaseOperaciones empleadoDiurno)
        {
            listaEmpleadoDiurno.Add(empleadoDiurno);
        }

        // inserta nuevo empleadoNocturno en listaEmpleadoNocturno
        public void InsertarEmpleadoNocturno(ClaseEmpleadoN empleadoNocturno)
        {
            listaEmpleadoNocturno.Add(empleadoNocturno);
        }

        //retorna listaEmpleadoDiurno
        public List<Entidades.ClaseOperaciones> RetornarEmpleadosDiurno()
        {
            return listaEmpleadoDiurno;
        }

        //retorna listaEmpleadoNocturno
        public List<ClaseEmpleadoN> RetornarEmpleadosNocturno()
        {
            return listaEmpleadoNocturno;
        }

        // Declarar lista // instancia de lista de clasePersona
        List<ClasePersona> listaPersonas = new List<ClasePersona>();

        // Agregar personas a lista
        public void InsertarPersona(ClasePersona persona)
        {
            listaPersonas.Add(persona);
        }

        // Imprimir lista
        public void ImprimirPersonas()
        {
            foreach (ClasePersona persona in listaPersonas)
            {
                Console.WriteLine("\n" + persona.DetalleCompleto());
            }
        }

        // EliminarEmpleadoDiurno
        public void EliminarEmpleadoDiurno(Entidades.ClaseOperaciones empDBuscar)
        {
            foreach (Entidades.ClaseOperaciones empD in listaEmpleadoDiurno)
            {
                if (empDBuscar.IdE == empD.IdE)
                {
                    listaEmpleadoDiurno.Remove(empD);
                    break;
                }
            }
        }

        //EliminarEmpleadoNocturno
        public void EliminarEmpleadoNocturno(ClaseEmpleadoN empNBuscar)
        {
            foreach (ClaseEmpleadoN empN in listaEmpleadoNocturno)
            {
                if (empNBuscar.IdE == empN.IdE)
                {
                    listaEmpleadoNocturno.Remove(empN);
                    break;
                }
            }
        }
    }
}
