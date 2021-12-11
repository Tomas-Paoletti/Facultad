using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacion.Objetos
{
   
    class Escultura : Obra
    {
        
        private String Escultor;

        public Escultura():base()
        {
            
        }

        public string Escultor1 { get => Escultor; set => Escultor = value; }




        /* public string Anio1 { get => Anio; set => Anio = value; }
         public string Escultor1 { get => Escultor; set => Escultor = value; }
         public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
         public string NObra1 { get => NObra; set => NObra = value; }*/

        public override void Exhibir(int id)
        {

            MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=museo; Uid=root; Pwd=1qazzaq1;");



            MySqlCommand comando = new MySqlCommand("SELECT * FROM obras WHERE idObras = @idObras", conexion);

            comando.Parameters.AddWithValue("@idObras", id);
            try
            {
                conexion.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("error", e);
            }



            MySqlDataReader Dato = comando.ExecuteReader();
            if (Dato.Read())
            {
                NObra1 = Dato["NombreDeLaObra"].ToString();
                Anio1 = Dato["AñoCreacion"].ToString();
                if (NObra1 == "Tríada de Osorkon II" || NObra1 == "La Victoria Alada De Samotracia") Anio1 += " A.C";
                else Anio1 += " D.C";
                Escultor = Dato["Creador"].ToString();
                Descripcion1 = Dato["Descripcion"].ToString();

            }
            conexion.Close();
        }

    }
}
