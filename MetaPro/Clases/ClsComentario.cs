using MetaPro.DataClases;
using MetaPro.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaPro.Clases
{
    internal class ClsComentario
    {
        DCTablasDataContext dc = new DCTablasDataContext();
        //Implementar Metodos del CRUD
        public List<Comentario> Listar()
        {
            List<Comentario> ListaComentario = dc.Comentario.ToList();

            return ListaComentario;
        }
        //Metodo obtener
        public Comentario Obtener(int idobjt)
        {
            Comentario objComentario = dc.Comentario.Single(c => c.IdComentario == idobjt);
            return objComentario;
        }

        //metodo Insertar

        public void Insertar(Comentario objComentario)
        {
            dc.Comentario.InsertOnSubmit(objComentario);
            dc.SubmitChanges();
        }

        public void Modificar(Comentario objComentario)
        {
            //Objetivo Objeti = dc.Comentario.Single(c => c.Titulo == objComentario.Titulo);
            //Objeti.Titulo = objComentario.Titulo;
            //Objeti.Descripcion = objComentario.Descripcion;
            //Objeti.IdCategoria = objObjetivo.IdCategoria;
            //Objeti.Avance = objObjetivo.Avance;
            //dc.SubmitChanges();
        }


    }
}
