using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacion.Objetos
{
    class Cuadro : Obra
    {
        private String Pintor;



        public Cuadro() : base()
        {
           
        
        }

        public string Pintor1 { get => Pintor; set => Pintor = value; }

        public override void Exhibir(int  id)
        {
           
            MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=museo; Uid=root; Pwd=1qazzaq1;");



            MySqlCommand comando = new MySqlCommand("SELECT * FROM obras WHERE idObras = @idObras", conexion);
           
            comando.Parameters.AddWithValue("@idObras", id);
            try
            {
                conexion.Open();
            }catch(Exception e)
            {
                Console.WriteLine("error"+e);
            }
            
            
            
            MySqlDataReader Dato = comando.ExecuteReader();
            if (Dato.Read())
            {
                NObra1 = Dato["NombreDeLaObra"].ToString();
                Anio1 = Dato["AñoCreacion"].ToString();
                if (NObra1 == "Tríada de Osorkon II" || NObra1 == "La Victoria Alada De Samotracia")  Anio1 += " A.C"; 
                else Anio1 += " D.C";
                Pintor = Dato["Creador"].ToString();
                Descripcion1 = Dato["Descripcion"].ToString();
                
            }
            conexion.Close();
        }
    }
}
