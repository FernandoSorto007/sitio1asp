using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace notasweb
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try{
                string nombre = Session["nombre"].ToString();
                Button1.Text = "Cerrar Sesion " + nombre;
            }
            catch(Exception ex)
            {
                Response.Redirect("Default.aspx?men=1");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Remove("nombre");
            Response.Redirect("Default.aspx");
        }
    }
}