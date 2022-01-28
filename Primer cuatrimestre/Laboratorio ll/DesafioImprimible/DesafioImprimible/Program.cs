using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioImprimible
{
    class Program
    {
        static void Main(string[] args)
        {
            Foto selfie = new Foto();
            Contrato contract = new Contrato();
            Documento word = new Documento();
            Impresora hp = new Impresora();

            hp.AgregarImprimible(selfie);
            hp.AgregarImprimible(word);
            hp.AgregarImprimible(contract);
            hp.ImprimirTodo();

            Console.Readkey();
        }

        
    }
}
