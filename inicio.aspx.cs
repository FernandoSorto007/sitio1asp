using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ventas;

namespace notasweb
{
    public partial class inicio : System.Web.UI.Page
    {
        Crud gc = new Crud();
        public void mostrardatos()
        {
            gc.LlenarGrid("select * from notaalumno where codalumno = '"+lblnombre.Text+"'", "notaalumno");
            GridView1.DataSource = gc.ds.Tables["notaalumno"];
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {            
            string codigo = Session["codigo"].ToString();
            lblnombre.Text = codigo;
            mostrardatos();
        }    
    }
}