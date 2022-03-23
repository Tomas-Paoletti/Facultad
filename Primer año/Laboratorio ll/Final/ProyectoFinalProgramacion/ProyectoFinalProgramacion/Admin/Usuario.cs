using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacion.Admin
{
    class Usuario
    {
        private Hashtable DatosUsuario = new Hashtable();

        public Usuario()
        {
        }

        public void CargarUsuarios()
        {
            DatosUsuario.Add("Esculturas", "Arte123");
            DatosUsuario.Add("Cuadros", "DaVinci1");
        }

        public int VerificarUsuarioInicio(String usuario, String contraseña)
        {
            if (DatosUsuario.ContainsKey(usuario) == true && DatosUsuario.ContainsValue(contraseña) == true) {
                if (usuario == "Esculturas" && contraseña == "Arte123")
                {
                    return 2;
                }
                else if ((usuario == "Cuadros" && contraseña == "DaVinci1"))
                {
                    return 1;
                }
            }
            else
            {

                return 0;

            }
            return 0;
        }

    }
}
