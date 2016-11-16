using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace CapaDatos

{
    public class DCliente
    {
        private int _Idcliente;
        private string _Nombre;
        private string _Tipo_documento;
        private string _Num_documento;
        private string _Direccion;
        private string _Telefono;
        private string _Departamento;

        public string Departamento1
        {
            get { return _Departamento; }
            set { _Departamento = value; }
        }
        private string _Provincia;

        public string Provincia1
        {
            get { return _Provincia; }
            set { _Provincia = value; }
        }
        private string _Distrito;

        public string Distrito1
        {
            get { return _Distrito; }
            set { _Distrito = value; }
        }
        private string _TextoBuscar;

        public int Idcliente
        { 
            get {return _Idcliente;}
            set {_Idcliente = value;}
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Tipo_documento
        {
            get { return _Tipo_documento; }
            set { _Tipo_documento = value; }
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

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        public DCliente() 
        {
        
        }

        public DCliente(int idcliente,string nombre, string tipo_documnto,
            string num_documento, string direccion,string telefono,string departamento, string provincia, string distrito, string textobuscar)
        {
            this.Idcliente = idcliente;
            this.Nombre = nombre;
            this.Tipo_documento = tipo_documnto;
            this.Num_documento = num_documento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Departamento1 = departamento;
            this.Provincia1  = provincia;
            this.Departamento1 = distrito;
            this.TextoBuscar = textobuscar;
        }

        public string Insertar(DCliente Cliente)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                 SqlCon.ConnectionString = Conexion.Cn;
                 SqlCon.Open();
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "spinsertar_cliente";
                 SqlCmd.CommandType = CommandType.StoredProcedure;
                 
                 SqlParameter ParIdcliente = new SqlParameter();
                 ParIdcliente.ParameterName = "@idcliente";
                 ParIdcliente.SqlDbType = SqlDbType.Int;
                 ParIdcliente.Direction = ParameterDirection.Output;
                 SqlCmd.Parameters.Add(ParIdcliente);

                 SqlParameter ParNombre = new SqlParameter();
                 ParNombre.ParameterName = "@nombre";
                 ParNombre.SqlDbType = SqlDbType.VarChar;
                 ParNombre.Size = 75;
                 ParNombre.Value = Cliente.Nombre;
                 SqlCmd.Parameters.Add(ParNombre);

                  SqlParameter ParTipo_documento = new SqlParameter();
                  ParTipo_documento.ParameterName = "@tipo_documento";
                  ParTipo_documento.SqlDbType = SqlDbType.VarChar;
                  ParTipo_documento.Size = 20;
                  ParTipo_documento.Value = Cliente.Tipo_documento;
                  SqlCmd.Parameters.Add(ParTipo_documento);

                  SqlParameter ParNum_documento = new SqlParameter();
                  ParNum_documento.ParameterName = "@num_documento";
                  ParNum_documento.SqlDbType = SqlDbType.VarChar;
                  ParNum_documento.Size = 11;
                  ParNum_documento.Value = Cliente.Num_documento;
                  SqlCmd.Parameters.Add(ParNum_documento);

                  SqlParameter ParDireccion = new SqlParameter();
                  ParDireccion.ParameterName = "@direccion";
                  ParDireccion.SqlDbType = SqlDbType.VarChar;
                  ParDireccion.Size = 100;
                  ParDireccion.Value = Cliente.Direccion;
                  SqlCmd.Parameters.Add(ParDireccion);

                  SqlParameter ParTelefono = new SqlParameter();
                  ParTelefono.ParameterName = "@telefono";
                  ParTelefono.SqlDbType = SqlDbType.VarChar;
                  ParTelefono.Size = 12;
                  ParTelefono.Value = Cliente.Telefono;
                  SqlCmd.Parameters.Add(ParTelefono);

                  SqlParameter ParNum_docume = new SqlParameter();
                  ParNum_docume.ParameterName = "@departamento";
                  ParNum_docume.SqlDbType = SqlDbType.VarChar;
                  ParNum_docume.Size = 20;
                  ParNum_docume.Value = Cliente.Departamento1;
                  SqlCmd.Parameters.Add(ParNum_docume);

                  SqlParameter ParDirecc = new SqlParameter();
                  ParDirecc.ParameterName = "@provincia";
                  ParDirecc.SqlDbType = SqlDbType.VarChar;
                  ParDirecc.Size = 30;
                  ParDirecc.Value = Cliente.Provincia1;
                  SqlCmd.Parameters.Add(ParDirecc);

                  SqlParameter ParTelef = new SqlParameter();
                  ParTelef.ParameterName = "@distrito";
                  ParTelef.SqlDbType = SqlDbType.VarChar;
                  ParTelef.Size = 40;
                  ParTelef.Value = Cliente.Distrito1;
                  SqlCmd.Parameters.Add(ParTelef);

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

          public string Editar(DCliente Cliente)
         {
             string rpta = "";
             SqlConnection SqlCon = new SqlConnection();
             try
             {
                 SqlCon.ConnectionString = Conexion.Cn;
                 SqlCon.Open();
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "speditar_cliente";
                 SqlCmd.CommandType = CommandType.StoredProcedure;

                
                 SqlParameter ParIdcliente= new SqlParameter();
                 ParIdcliente.ParameterName = "@idcliente";
                 ParIdcliente.SqlDbType = SqlDbType.Int;
                 ParIdcliente.Value = Cliente.Idcliente;
                 SqlCmd.Parameters.Add(ParIdcliente);

                 SqlParameter ParNombre = new SqlParameter();
                 ParNombre.ParameterName = "@nombre";
                 ParNombre.SqlDbType = SqlDbType.VarChar;
                 ParNombre.Size = 75;
                 ParNombre.Value = Cliente.Nombre;
                 SqlCmd.Parameters.Add(ParNombre);
                 
                 SqlParameter ParTipo_documento = new SqlParameter();
                 ParTipo_documento.ParameterName = "@tipo_documento";
                 ParTipo_documento.SqlDbType = SqlDbType.VarChar;
                 ParTipo_documento.Size = 20;
                 ParTipo_documento.Value = Cliente.Tipo_documento;
                 SqlCmd.Parameters.Add(ParTipo_documento);

                 SqlParameter ParNum_documento = new SqlParameter();
                 ParNum_documento.ParameterName = "@num_documento";
                 ParNum_documento.SqlDbType = SqlDbType.VarChar;
                 ParNum_documento.Size = 11;
                 ParNum_documento.Value = Cliente.Num_documento;
                 SqlCmd.Parameters.Add(ParNum_documento);

                 SqlParameter ParDireccion = new SqlParameter();
                 ParDireccion.ParameterName = "@direccion";
                 ParDireccion.SqlDbType = SqlDbType.VarChar;
                 ParDireccion.Size = 100;
                 ParDireccion.Value = Cliente.Direccion;
                 SqlCmd.Parameters.Add(ParDireccion);

                 SqlParameter ParTelefono = new SqlParameter();
                 ParTelefono.ParameterName = "@telefono";
                 ParTelefono.SqlDbType = SqlDbType.VarChar;
                 ParTelefono.Size = 12;
                 ParTelefono.Value = Cliente.Telefono;
                 SqlCmd.Parameters.Add(ParTelefono);

                 SqlParameter ParNum_docume = new SqlParameter();
                 ParNum_docume.ParameterName = "@departamento";
                 ParNum_docume.SqlDbType = SqlDbType.VarChar;
                 ParNum_docume.Size = 20;
                 ParNum_docume.Value = Cliente.Departamento1;
                 SqlCmd.Parameters.Add(ParNum_docume);

                 SqlParameter ParDirecc = new SqlParameter();
                 ParDirecc.ParameterName = "@provincia";
                 ParDirecc.SqlDbType = SqlDbType.VarChar;
                 ParDirecc.Size = 30;
                 ParDirecc.Value = Cliente.Provincia1;
                 SqlCmd.Parameters.Add(ParDirecc);

                 SqlParameter ParTelef = new SqlParameter();
                 ParTelef.ParameterName = "@distrito";
                 ParTelef.SqlDbType = SqlDbType.VarChar;
                 ParTelef.Size = 40;
                 ParTelef.Value = Cliente.Distrito1;
                 SqlCmd.Parameters.Add(ParTelef);

          
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

         public string Eliminar(DCliente Cliente)
         {
             string rpta = " ";
             SqlConnection SqlCon = new SqlConnection();
             try
             {
                 SqlCon.ConnectionString = Conexion.Cn;
                 SqlCon.Open();
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "speliminar_cliente";
                 SqlCmd.CommandType = CommandType.StoredProcedure;

                 SqlParameter ParIdcliente= new SqlParameter();
                 ParIdcliente.ParameterName = "@idcliente";
                 ParIdcliente.SqlDbType = SqlDbType.Int;
                 ParIdcliente.Value = Cliente.Idcliente;
                 SqlCmd.Parameters.Add(ParIdcliente);

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
             DataTable DtResultado = new DataTable("cliente");
             SqlConnection SqlCon = new SqlConnection();
             try
             {
                 SqlCon.ConnectionString = Conexion.Cn;
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "spmostrar_cliente";
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

         public DataTable MostrarSolo()
         {
             DataTable DtResultado = new DataTable("clientesolo");
             SqlConnection SqlCon = new SqlConnection();
             try
             {
                 SqlCon.ConnectionString = Conexion.Cn;
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "spmostrar_cliente_solo";
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

         public DataTable BuscarNum_Documento(DCliente Cliente)
         {

             DataTable DtResultado = new DataTable("cliente");
             SqlConnection SqlCon = new SqlConnection();
             try
             {
                 SqlCon.ConnectionString = Conexion.Cn;
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "spbuscar_cliente_num_documento";
                 SqlCmd.CommandType = CommandType.StoredProcedure;

                 SqlParameter ParTextoBuscar = new SqlParameter();
                 ParTextoBuscar.ParameterName = "@textobuscar";
                 ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                 ParTextoBuscar.Size = 50;
                 ParTextoBuscar.Value = Cliente.TextoBuscar;
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

         public DataTable MostrarDir(DCliente Cliente)
         {

             DataTable DtResultado = new DataTable("clientedir");
             SqlConnection SqlCon = new SqlConnection();
             try
             {
                 SqlCon.ConnectionString = Conexion.Cn;
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "spmostrar_direccion_cliente";
                 SqlCmd.CommandType = CommandType.StoredProcedure;

                 SqlParameter ParTextoBuscar = new SqlParameter();
                 ParTextoBuscar.ParameterName = "@textobuscar";
                 ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                 ParTextoBuscar.Size = 75;
                 ParTextoBuscar.Value = Cliente.TextoBuscar;
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

         public DataTable Departamento()
         {
             DataTable DtResultado = new DataTable("departamento");
             SqlConnection SqlCon = new SqlConnection();
             try
             {
                 SqlCon.ConnectionString = Conexion.Cn;
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "spmostrar_departamento";
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

         public DataTable Provincia(DCliente Cliente)
         {

             DataTable DtResultado = new DataTable("provincia");
             SqlConnection SqlCon = new SqlConnection();
             try
             {
                 SqlCon.ConnectionString = Conexion.Cn;
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "spmostrar_provincia";
                 SqlCmd.CommandType = CommandType.StoredProcedure;

                 SqlParameter ParTextoBuscar = new SqlParameter();
                 ParTextoBuscar.ParameterName = "@textobuscar";
                 ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                 ParTextoBuscar.Size = 50;
                 ParTextoBuscar.Value = Cliente.TextoBuscar;
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

         public DataTable Distrito(DCliente Cliente)
         {

             DataTable DtResultado = new DataTable("distrito");
             SqlConnection SqlCon = new SqlConnection();
             try
             {
                 SqlCon.ConnectionString = Conexion.Cn;
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "spmostrar_distrito";
                 SqlCmd.CommandType = CommandType.StoredProcedure;

                 SqlParameter ParTextoBuscar = new SqlParameter();
                 ParTextoBuscar.ParameterName = "@textobuscar";
                 ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                 ParTextoBuscar.Size = 75;
                 ParTextoBuscar.Value = Cliente.TextoBuscar;
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

     }
}

