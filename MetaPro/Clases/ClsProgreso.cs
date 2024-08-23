using MetaPro.DataClases;
using MetaPro.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MetaPro.Clases
{
    internal class ClsProgreso
    {
        DCTablasDataContext dc = new DCTablasDataContext();
        //Implementar Metodos del CRUD
        public List<Progreso> Listar()
        {
            List<Progreso> ListaProgreso = dc.Progreso.ToList();

            return ListaProgreso;
        }
        //Metodo obtener
        public Progreso Obtener(int idobjt)
        {
            Progreso objProgreso = dc.Progreso.Single(c => c.IdObjetivo == idobjt);
            return objProgreso;
        }

        //metodo Insertar

        public void Insertar(Progreso objProgreso)
        {
            dc.Progreso.InsertOnSubmit(objProgreso);
            dc.SubmitChanges();
        }
    }
}
