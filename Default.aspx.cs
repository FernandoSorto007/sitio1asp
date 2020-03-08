using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ventas;

namespace notasweb
{
    public partial class Default : System.Web.UI.Page
    {
        Crud gc = new Crud();
        private void limpiar()
        {
            txtusuario.Text = "";
            txtcontra.Text = "";           
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {          
           string consulta = "select * from alumno where cod_usuario = '" + txtusuario.Text + "' AND pass_usuario = '" + txtcontra.Text + "'";
           gc.consultarTex(consulta);          
            if (gc.dr.Read())
            {              
                string codusuario = Convert.ToString(gc.dr[0]);
                string nombreusuario = Convert.ToString(gc.dr[1]);
                Session["nombre"] = nombreusuario;
                Session["codigo"] = codusuario;
                limpiar();
                Response.Redirect("inicio.aspx");
                gc.Cerrar();
            }
            else
            {
            lblerror.Text = "fallo en inicio de sesion";
            limpiar();   
            gc.Cerrar();             
            }           
        }
    }
}