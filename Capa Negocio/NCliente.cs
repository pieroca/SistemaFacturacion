using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NCliente
    {
        public static string Insertar(string nombre, string tipo_documnto,
           string num_documento, string direccion, string telefono, string departamento, string provincia, string distrito)
        {
            DCliente Obj = new DCliente();
            Obj.Nombre = nombre;
            Obj.Tipo_documento= tipo_documnto;
            Obj.Num_documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Departamento1 = departamento;
            Obj.Provincia1 = provincia;
            Obj.Distrito1= distrito;
            
            return Obj.Insertar(Obj);
        }

        public static string Editar(int idcliente, string nombre, string tipo_documnto,
            string num_documento, string direccion, string telefono, string departamento, string provincia, string distrito)
        {
            DCliente Obj = new DCliente();
            Obj.Idcliente= idcliente;
            Obj.Nombre = nombre;
            Obj.Tipo_documento = tipo_documnto;
            Obj.Num_documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Departamento1 = departamento;
            Obj.Provincia1 = provincia;
            Obj.Distrito1 = distrito;
            return Obj.Editar(Obj);
        }

        public static string Eliminar(int idcliente)
        {
            DCliente Obj = new DCliente();
            Obj.Idcliente= idcliente;
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DCliente().Mostrar();
        }

        public static DataTable MostrarSolo()
        {
            return new DCliente().MostrarSolo();
        }

        public static DataTable MostrarDir(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.MostrarDir(Obj);
        }

        public static DataTable BuscarNum_Documento(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNum_Documento(Obj);
        }

        public static DataTable Departamento()
        {
            return new DCliente().Departamento();
        }

        public static DataTable Provincia(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.Provincia(Obj);
        }

        public static DataTable Distrito(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.Distrito(Obj);
        }

    }
}   

