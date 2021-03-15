using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceLibros
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        LibroService.LibrosSoapClient Lib = new LibroService.LibrosSoapClient();

        public void clearAllTextBox()
        {
            textBoxTitulo.Text = "";
            textBoxAutor.Text = "";
            textBoxPrecio.Text = "";
            textBoxFecha.Text = "";
        }
        public void showDataGridView()
        {
            DataSet ds2 = Lib.Lista();
            ShowDataGridViewLibros.DataSource = ds2.Tables[0];
            ShowDataGridViewLibros.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            showDataGridView();
        }

        protected void BtnDElete_Click(object sender, EventArgs e)
        {

            Lib.Eliminar(Convert.ToInt32(textBoxId.Text));
            textBoxId.Text = "";
            showDataGridView();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Lib.addBook(textBoxTitulo.Text, textBoxAutor.Text, Convert.ToDouble(textBoxPrecio.Text), textBoxFecha.Text);
            clearAllTextBox();
            showDataGridView();
        }

        protected void btnGetOneBook_Click(object sender, EventArgs e)
        {
            DataSet ds = Lib.getOneBook(Convert.ToInt32(textBoxId.Text));
            textBoxTitulo.Text = ds.Tables[0].Rows[0][1].ToString();
            textBoxAutor.Text = ds.Tables[0].Rows[0][2].ToString();
            textBoxPrecio.Text = ds.Tables[0].Rows[0][3].ToString();
            textBoxFecha.Text = ds.Tables[0].Rows[0][4].ToString();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Lib.updateBook(Convert.ToInt32(textBoxId.Text), textBoxTitulo.Text, textBoxAutor.Text, Convert.ToDouble(textBoxPrecio.Text),textBoxFecha.Text);
            clearAllTextBox();
            showDataGridView();
           
        }

    }
}