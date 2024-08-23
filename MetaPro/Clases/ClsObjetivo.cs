using MetaPro.DataClases;
using MetaPro.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaPro.Clases
{
    public class ClsObjetivo
    {

        DCTablasDataContext dc = new DCTablasDataContext();
        //Implementar Metodos del CRUD
        public List<Objetivo> Listar()
        {
            List<Objetivo> ListaObjetivo = dc.Objetivo.ToList();

            return ListaObjetivo;
        }
        //Metodo obtener
        public Objetivo Obtener(string titulo)
        {
            Objetivo objObjetivo = dc.Objetivo.Single(c => c.Titulo == titulo);
            return objObjetivo;
        }

        //metodo Insertar

        public void Insertar(Objetivo objObjetivo)
        {
            dc.Objetivo.InsertOnSubmit(objObjetivo);
            dc.SubmitChanges();
        }

        //metodo modificar
        public void Modificar(Objetivo objObjetivo)
        {
            Objetivo Objeti = dc.Objetivo.Single(c => c.Titulo == objObjetivo.Titulo);
            Objeti.Titulo = objObjetivo.Titulo;
            Objeti.Descripcion = objObjetivo.Descripcion;
            Objeti.IdCategoria = objObjetivo.IdCategoria;
            Objeti.Avance = objObjetivo.Avance;
            dc.SubmitChanges();
        }
        //Metodo Eliminar
        public void Eliminar(string titulo)
        {
            Objetivo objObjetivo = dc.Objetivo.Single(c => c.Titulo == titulo);
            dc.Objetivo.DeleteOnSubmit(objObjetivo);
            dc.SubmitChanges();
        }

       
       


    }
}
