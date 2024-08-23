using MetaPro.DataClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaPro.Clases
{
    public class ClsCriaturita
    {
        DCTablasDataContext dc = new DCTablasDataContext();

        public List<Criaturita> Listar()
        {
            List<Criaturita> ListaCriaturitas = dc.Criaturita.ToList();

            return ListaCriaturitas;
        }
        public void Insertar(Criaturita objCriaturita)
        {
            dc.Criaturita.InsertOnSubmit(objCriaturita);
            dc.SubmitChanges();
        }
    }
}
