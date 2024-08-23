using MetaPro.DataClases;
using MetaPro.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaPro.Clases
{
    public class ClsAmigo
    {
        DCTablasDataContext dc = new DCTablasDataContext();
        public List<Amigo> Listar()
        {
            List<Amigo> ListaAmigos = dc.Amigo.ToList();

            return ListaAmigos;
        }
        public void Insertar(Amigo objAmigo)
        {
            dc.Amigo.InsertOnSubmit(objAmigo);
            dc.SubmitChanges();
        }
    }
}
