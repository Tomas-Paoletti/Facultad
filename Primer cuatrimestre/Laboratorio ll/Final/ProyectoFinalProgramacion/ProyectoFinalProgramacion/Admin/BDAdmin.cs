using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoFinalProgramacion
{
          

    class BDAdmin
    {

        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=museo; Uid=root; Pwd=1qazzaq1;");

        public  void PrenderBase()
        {
           
            conexion.Open();
        }
        public void ApagarBase()
        {
            
            conexion.Close();
        }

        public DataTable CargarDatos(int tipo)
        {
            String instruccion;
            if (tipo == 2)
            {
                instruccion = "SELECT * FROM obras WHERE tipo=2";

            }
            else
            {
                instruccion = "SELECT * FROM obras WHERE tipo=1";
            }
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, conexion);
             DataTable tabla = new DataTable();
             adp.Fill(tabla);
            return tabla;

        }
        public void AgregarDatos(String nombre , int aCreacion,  String creador, String descripcion, int  id, int tipo)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion;
            comando.CommandText = ("INSERT INTO obras(AñoCreacion,Creador,Descripcion,NombreDeLaObra,tipo) VALUES('" + aCreacion + "','" + creador + "','" + descripcion + "', '" + nombre + "','" + tipo+ "');");
            comando.ExecuteNonQuery();
        }
        public void BorrarDatos(int id)
        {
            MySqlCommand comand = new MySqlCommand("DELETE FROM obras WHERE idObras = @idObra", conexion);
           
             comand.Parameters.AddWithValue("@idObra", id);
            comand.ExecuteNonQuery();
        }
        public void ModificarDatos(int id,int ACreacion,String nombre, String descripcion,string  Creador )
        {
            String actualizar = "UPDATE obras SET idObras='" + id + "',AñoCreacion='" + ACreacion + "',Creador='" + Creador + "',Descripcion='" + descripcion+ "',NombreDeLaObra='" + nombre + "'WHERE idObras='" + id + "';";
            MySqlCommand comando = new MySqlCommand(actualizar, conexion);
            comando.ExecuteNonQuery();
        }
    }
}
