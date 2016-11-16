using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
     public class DTrabajador
    {
        private int _Idtrabajador;
        private string _Nombre;
        private string _Apellidos;
        private string _Num_documento;
        private string _Direccion;
        private string _Telefono;
        private string _Acceso;
        private string _Usuario;
        private string _Password;
        private string _TextoBuscar;

        public int Idtrabajador
        {
            get { return _Idtrabajador; }
            set { _Idtrabajador = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }

        public string Num_documento
        {
            get { return _Num_documento; }
            set { _Num_documento = value; }
        }

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        public string Acceso
        {
            get { return _Acceso; }
            set { _Acceso = value; }
        }

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }
          public DTrabajador() 
        {
        
        }

          public DTrabajador(int idtrabajador, string nombre, string apellidos, string num_documento,
              string direccion,string telefono, string acceso, string usuario, string password ,string textobuscar)
        {
            this.Idtrabajador= idtrabajador;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Num_documento = num_documento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Acceso= acceso;
            this.Usuario= usuario;
            this.Password= password;
            this.TextoBuscar = textobuscar;
        }

          public string Insertar(DTrabajador Trabajador)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_trabajador";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdtrabajador= new SqlParameter();
                ParIdtrabajador.ParameterName = "@idtrabajador";
                ParIdtrabajador.SqlDbType = SqlDbType.Int;
                ParIdtrabajador.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdtrabajador);

                SqlParameter ParNombre= new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 20;
                ParNombre.Value = Trabajador.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidos= new SqlParameter();
                ParApellidos.ParameterName = "@apellidos";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 40;
                ParApellidos.Value = Trabajador.Apellidos;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParNum_documento = new SqlParameter();
                ParNum_documento.ParameterName = "@num_documento";
                ParNum_documento.SqlDbType = SqlDbType.VarChar;
                ParNum_documento.Size = 8;
                ParNum_documento.Value = Trabajador.Num_documento;
                SqlCmd.Parameters.Add(ParNum_documento);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Trabajador.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 10;
                ParTelefono.Value = Trabajador.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParAcceso= new SqlParameter();
                ParAcceso.ParameterName = "@acceso";
                ParAcceso.SqlDbType = SqlDbType.VarChar;
                ParAcceso.Size = 20;
                ParAcceso.Value = Trabajador.Acceso;
                SqlCmd.Parameters.Add(ParAcceso);

                SqlParameter ParUsuario= new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 20;
                ParUsuario.Value = Trabajador.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassword= new SqlParameter();
                ParPassword.ParameterName = "@password";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 20;
                ParPassword.Value = Trabajador.Password;
                SqlCmd.Parameters.Add(ParPassword);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

          public string Editar(DTrabajador Trabajador)
         {
             string rpta = "";
             SqlConnection SqlCon = new SqlConnection();
             try
             {
                 SqlCon.ConnectionString = Conexion.Cn;
                 SqlCon.Open();
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "speditar_trabajador";
                 SqlCmd.CommandType = CommandType.StoredProcedure;

                
                SqlParameter ParIdtrabajador= new SqlParameter();
                ParIdtrabajador.ParameterName = "@idtrabajador";
                ParIdtrabajador.SqlDbType = SqlDbType.Int;
                ParIdtrabajador.Value = Trabajador.Idtrabajador;
                SqlCmd.Parameters.Add(ParIdtrabajador);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 20;
                ParNombre.Value = Trabajador.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@apellidos";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 40;
                ParApellidos.Value = Trabajador.Apellidos;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParNum_documento = new SqlParameter();
                ParNum_documento.ParameterName = "@num_documento";
                ParNum_documento.SqlDbType = SqlDbType.VarChar;
                ParNum_documento.Size = 8;
                ParNum_documento.Value = Trabajador.Num_documento;
                SqlCmd.Parameters.Add(ParNum_documento);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Trabajador.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 10;
                ParTelefono.Value = Trabajador.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParAcceso = new SqlParameter();
                ParAcceso.ParameterName = "@acceso";
                ParAcceso.SqlDbType = SqlDbType.VarChar;
                ParAcceso.Size = 20;
                ParAcceso.Value = Trabajador.Acceso;
                SqlCmd.Parameters.Add(ParAcceso);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 20;
                ParUsuario.Value = Trabajador.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 20;
                ParPassword.Value = Trabajador.Password;
                SqlCmd.Parameters.Add(ParPassword);

          
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el registro";
             }
             catch (Exception ex)
             {
                 rpta = ex.Message;
             }
             finally
             {
                 if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
             }
             return rpta;

         }

         public string Eliminar(DTrabajador Trabajador)
         {
             string rpta = " ";
             SqlConnection SqlCon = new SqlConnection();
             try
             {
                 SqlCon.ConnectionString = Conexion.Cn;
                 SqlCon.Open();
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "speliminar_trabajador";
                 SqlCmd.CommandType = CommandType.StoredProcedure;

                 SqlParameter ParIdtrabajador= new SqlParameter();
                 ParIdtrabajador.ParameterName = "@idtrabajador";
                 ParIdtrabajador.SqlDbType = SqlDbType.Int;
                 ParIdtrabajador.Value = Trabajador.Idtrabajador;
                 SqlCmd.Parameters.Add(ParIdtrabajador);

                 rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el registro";
             }
             catch (Exception ex)
             {
                 rpta = ex.Message;
             }
             finally
             {
                 if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
             }
             return rpta;

         }

         public DataTable Mostrar()
         {
             DataTable DtResultado = new DataTable("trabajador");
             SqlConnection SqlCon = new SqlConnection();
             try
             {
                 SqlCon.ConnectionString = Conexion.Cn;
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "spmostrar_trabajador";
                 SqlCmd.CommandType = CommandType.StoredProcedure;

                 SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                 SqlDat.Fill(DtResultado);
             }
             catch (Exception ex)
             {
                 DtResultado = null;
             }
             return DtResultado;

         }

         public DataTable BuscarApellidos(DTrabajador Trabajador)
         {

             DataTable DtResultado = new DataTable("trabajador");
             SqlConnection SqlCon = new SqlConnection();
             try
             {
                 SqlCon.ConnectionString = Conexion.Cn;
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "spbuscar_trabajador_apellidos";
                 SqlCmd.CommandType = CommandType.StoredProcedure;

                 SqlParameter ParTextoBuscar = new SqlParameter();
                 ParTextoBuscar.ParameterName = "@textobuscar";
                 ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                 ParTextoBuscar.Size = 50;
                 ParTextoBuscar.Value = Trabajador.TextoBuscar;
                 SqlCmd.Parameters.Add(ParTextoBuscar);

                 SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                 SqlDat.Fill(DtResultado);
             }
             catch (Exception ex)
             {
                 DtResultado = null;
             }
             return DtResultado;
         }

         public DataTable BuscarNum_Documento(DTrabajador Trabajador)
         {

             DataTable DtResultado = new DataTable("trabajador");
             SqlConnection SqlCon = new SqlConnection();
             try
             {
                 SqlCon.ConnectionString = Conexion.Cn;
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "spbuscar_trabajador_num_documento";
                 SqlCmd.CommandType = CommandType.StoredProcedure;

                 SqlParameter ParTextoBuscar = new SqlParameter();
                 ParTextoBuscar.ParameterName = "@textobuscar";
                 ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                 ParTextoBuscar.Size = 50;
                 ParTextoBuscar.Value = Trabajador.TextoBuscar;
                 SqlCmd.Parameters.Add(ParTextoBuscar);

                 SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                 SqlDat.Fill(DtResultado);
             }
             catch (Exception ex)
             {
                 DtResultado = null;
             }
             return DtResultado;
         }
    
     public DataTable Login(DTrabajador Trabajador)
         {

             DataTable DtResultado = new DataTable("trabajador");
             SqlConnection SqlCon = new SqlConnection();
             try
             {
                 SqlCon.ConnectionString = Conexion.Cn;
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "splogin";
                 SqlCmd.CommandType = CommandType.StoredProcedure;

                 SqlParameter ParUsuario= new SqlParameter();
                 ParUsuario.ParameterName = "@usuario";
                 ParUsuario.SqlDbType = SqlDbType.VarChar;
                 ParUsuario.Size = 20;
                 ParUsuario.Value = Trabajador.Usuario;
                 SqlCmd.Parameters.Add(ParUsuario);

                 SqlParameter ParPassword = new SqlParameter();
                 ParPassword.ParameterName = "@password";
                 ParPassword.SqlDbType = SqlDbType.VarChar;
                 ParPassword.Size = 20;
                 ParPassword.Value = Trabajador.Password;
                 SqlCmd.Parameters.Add(ParPassword);

                 SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                 SqlDat.Fill(DtResultado);
             }
             catch (Exception ex)
             {
                 DtResultado = null;
             }
             return DtResultado;
         }

     public DataTable Loginad(DTrabajador Trabajador)
         {

             DataTable DtResultado = new DataTable("trabajador");
             SqlConnection SqlCon = new SqlConnection();
             try
             {
                 SqlCon.ConnectionString = Conexion.Cn;
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "sploginad";
                 SqlCmd.CommandType = CommandType.StoredProcedure;

                 SqlParameter ParUsuario= new SqlParameter();
                 ParUsuario.ParameterName = "@usuario";
                 ParUsuario.SqlDbType = SqlDbType.VarChar;
                 ParUsuario.Size = 20;
                 ParUsuario.Value = Trabajador.Usuario;
                 SqlCmd.Parameters.Add(ParUsuario);

                 SqlParameter ParPassword = new SqlParameter();
                 ParPassword.ParameterName = "@password";
                 ParPassword.SqlDbType = SqlDbType.VarChar;
                 ParPassword.Size = 20;
                 ParPassword.Value = Trabajador.Password;
                 SqlCmd.Parameters.Add(ParPassword);

                 SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                 SqlDat.Fill(DtResultado);
             }
             catch (Exception ex)
             {
                 DtResultado = null;
             }
             return DtResultado;
         }
     }

}


