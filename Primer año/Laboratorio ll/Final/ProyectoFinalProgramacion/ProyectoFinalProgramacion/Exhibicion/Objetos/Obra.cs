using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacion.Objetos
{
    abstract class  Obra
    {
        private String Anio, Descripcion, NObra;

        public string Anio1 { get => Anio; set => Anio = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public string NObra1 { get => NObra; set => NObra = value; }

        protected Obra(string anio, string descripcion, string nObra, string anio1, string descripcion1, string nObra1)
        {
            Anio = anio;
            Descripcion = descripcion;
            NObra = nObra;
            Anio1 = anio1;
            Descripcion1 = descripcion1;
            NObra1 = nObra1;
        }

        protected Obra()
        {
        }

        public abstract void Exhibir(int id);
            
    }
}
