using MetaPro.DataClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaPro.Clases
{
    public class ClsUsuario
    {
        DCTablasDataContext dc = new DCTablasDataContext();

        public List<Usuario> Listar()
        {
            List<Usuario> ListaUsuarios = dc.Usuario.ToList();

            return ListaUsuarios;
        }
        public void Insertar(Usuario objUsuario)
        {
            dc.Usuario.InsertOnSubmit(objUsuario);
            dc.SubmitChanges();
        }

    }
}
