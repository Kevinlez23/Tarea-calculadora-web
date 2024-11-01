using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class calculadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Radiobutton();
            //metodo_Dropdown();
            metodo_Checkbox();

        }

        public void metodo_Checkbox()
        {
            float num1 = 0, num2 = 0, total = 0;

            num1 = float.Parse(Tvalor1.Text);
            num2 = float.Parse(Tvalor2.Text);

            string valor = "";
            if (Csuma.Checked)
            {
                total = num1 + num2;
                valor = "suma:" + total.ToString() + valor;

            }
            if (Cresta.Checked)
            {
                total = num1 - num2;
                valor = valor + "Resta: " + total.ToString();
            }
            Lresultado.Text = valor;
        }

        public void metodo_Dropdown()
        {
            float num1 = 0, num2 = 0, total = 0;

            num1 = float.Parse(Tvalor1.Text);
            num2 = float.Parse(Tvalor2.Text);

            if(Dlista.SelectedIndex==0)
            {
                total = num1 + num2;
            }else if(Dlista.SelectedIndex==1)
            {
                total = num1 - num2;

            }
            Lresultado.Text = total.ToString();

        }

        public void Radiobutton()
        {
            float num1 = 0, num2 = 0, total = 0;

            num1 = float.Parse(Tvalor1.Text);
            num2 = float.Parse(Tvalor2.Text);

            if (rsuma.Checked)
            {
                total = num1 + num2;
            } 
            else if (Rresta.Checked)
            {
                total = num1 - num2;
            } else if (Rmultiplicar.Checked)
            {
                total = num1 * num2;
            } else if (Rdivision.Checked)
            {
                total = num1 / num2;
            }
            Lresultado.Text = total.ToString();
               
        

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}