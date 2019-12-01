using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;
using System.Web;
using System.Web.UI;

namespace CtrlWebT.Controllers
{
    public class VerInventariosController : ApiController
    {
        public SqlConnection inv1 = new SqlConnection("Data Source=(local);Initial Catalog=Ctrl_Test;Persist Security Info=True;User ID=sa;Password=1234");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dain1 = new SqlDataAdapter("select * from icInventarioFisicoDetalle", inv1);
            DataTable dtin = new DataTable();
            dain1.Fill(dtin);
        }

        void consultaInventario()
        {
//            SqlDataAdapter dainv1 = new SqlDataAdapter("select NoInventario, IdProducto, Costo, Cantidad, Conteo, Diferencia, TotalCantidad, TotalConteo, TotalDiferencia from icInventarioFisicoDetalle where IdProducto like ", inv1);
  //          DataTable dtinv1 = new DataTable();
    //        dainv1.Fill(dtinv1);
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            consultaInventario();
        }
    }
}
