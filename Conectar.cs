using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comedor
{

    public class Conectar
    {

        public SqlConnection connect = new SqlConnection();

        public Conectar()
        {
            try
            {

                connect = new SqlConnection("Server=DESKTOP-SAH83BP;Database=Comedor;integrated security = true");
                connect.Open();
            }
            catch (Exception)
            {


            }
        }

        public int iniciarSesion(String user,String pass)
        {



            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@user", SqlDbType.VarChar);
            param[0].Value = user;
            param[1] = new SqlParameter("@pass", SqlDbType.VarChar);
            param[1].Value = pass;
            

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "iniciar";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);
            Console.WriteLine("antes");
            Console.WriteLine(cmd.ExecuteScalar());
            return (int)cmd.ExecuteScalar();
        }

        public void listarUsuarios(DataGridView GridView1)
        {

            SqlCommand cmd = new SqlCommand();
         

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MostrarUsuarios";
            cmd.Connection = connect;


          
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;

        }

        public void editarUsuario(DataGridView GridView1, int id, String tel, String dir)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@tel", SqlDbType.Char);
            param[1].Value = tel;
            param[2] = new SqlParameter("@dir", SqlDbType.VarChar);
            param[2].Value = dir;


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "editUsuario";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);


        }

        public void eliminarUsuario(int id)
        {
            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "eliminarUsuario";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);
        }

        public void insertarUsuario(String dni, String user,String nombre, String apellido, String contra, String tel, String dir)
        {

            Console.WriteLine(contra);

            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[7];
                param[0] = new SqlParameter("@dni", SqlDbType.Char);
                param[0].Value = dni;
                param[1] = new SqlParameter("@Puser", SqlDbType.VarChar);
                param[1].Value = user;
                param[2] = new SqlParameter("@Pnombre", SqlDbType.VarChar);
                param[2].Value = nombre;
                param[3] = new SqlParameter("@Papellido", SqlDbType.VarChar);
                param[3].Value = apellido;
                param[4] = new SqlParameter("@contra", SqlDbType.VarChar);
                param[4].Value = contra;
                param[5] = new SqlParameter("@direccion", SqlDbType.VarChar);
                param[5].Value = dir;
                param[6] = new SqlParameter("@telefono", SqlDbType.Char);
                param[6].Value = tel;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertarUsuario";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la insercion");
                return;
            }


        }

    }
}
