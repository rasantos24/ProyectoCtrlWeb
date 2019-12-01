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
    public partial class WebForm1 : System.Web.UI.Page
    {
        public SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=Ctrl_Test;Persist Security Info=True;User ID=sa;Password=1234");

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select Descripcion, Costo, Precio, Impuesto, PrecioConImpuesto from icProductos;", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        void consultaDato()
        {
            SqlDataAdapter da = new SqlDataAdapter("select Descripcion, Costo, Precio, Impuesto, PrecioConImpuesto from icProductos where Descripcion like '" + TextBox1.Text +"%'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            consultaDato(); 
        }
    }
}