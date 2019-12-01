using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace CtrlWebT
{
    public partial class VerInventarios : System.Web.UI.Page
    {
        public SqlConnection inv = new SqlConnection("Data Source=(local);Initial Catalog=Ctrl_Test;Persist Security Info=True;User ID=sa;Password=1234");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dain = new SqlDataAdapter("select * from icInventarioFisicoDetalle", inv);
            DataTable dtin = new DataTable();
            dain.Fill(dtin);
            this.GridView1.DataSource = dtin;
            GridView1.DataBind();
        }

        void consultaInventario()
        {
            SqlDataAdapter dainv = new SqlDataAdapter("select NoInventario, IdProducto, Costo, Cantidad, Conteo, Diferencia, TotalCantidad, TotalConteo, TotalDiferencia from icInventarioFisicoDetalle where IdProducto like '" + TextBox1.Text +"%'", inv);
            DataTable dtinv = new DataTable();
            dainv.Fill(dtinv);
            this.GridView1.DataSource = dtinv;
            GridView1.DataBind();
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            consultaInventario();
        }
    }
}