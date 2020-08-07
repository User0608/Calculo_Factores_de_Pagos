using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factors
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Operation OO;
        public Form()
        {
            InitializeComponent();
            OO = new Operation();
            this.txtNumeroDecimales.SelectedIndex = 4;
            initialize();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.CenterToParent();
        }
        private void initialize()
        {
            this.btnAbout.Click += new EventHandler(this.btnAbout_Click);
            this.txtNumeroDecimales.SelectedIndexChanged+= new EventHandler(txtNumeroDecimales_SelectionChangeCommitted);
            this.btnClean.Click += new EventHandler(this.btnClean_Click);
        }


        private void btnAbout_Click(object sender, EventArgs e)
        {
            string mensaje = "" +
                "Esta herramienta fue desarrollada por estudiantes\n" +
                "de Ingeniería de Sistemas en el curso de ingeniería\n" +
                "económica en la Universidad Nacional de Trujillo - VJ,\n" +
                "para facilitar la tarea de calcular factores de pago.\n" +
                "\n" +
                "Docente: Mg.POEMAPE ROJAS,GLORIA IRENE \n" +
                "\n" +
                "                                    ksaucedo@unitru.edu.pe\n";
                MessageBox.Show(this,mensaje,"Mensaje");
        }
        private void txtNumeroDecimales_SelectionChangeCommitted(object sender, EventArgs e)
        {

            this.btnFP_Click(sender, e);
            this.btnPF_Click(sender, e);
            this.btnFA_Click(sender, e);
            this.btnAF_Click(sender, e);
            this.btnPA_Click(sender, e);
            this.btnAP_Click(sender, e);
            this.btnPG_Click(sender, e);
            this.btnAG_Click(sender, e);
            this.btnPA1_Click(sender, e);
            this.Menu.Focus();
            
        }

            
        private void btnClean_Click(object sender, EventArgs e)
        {
            this.txtFP.Text="";
            this.txtPF.Text="";
            this.txtFA.Text="";
            this.txtAF.Text="";
            this.txtPA.Text="";
            this.txtAP.Text="";
            this.txtPG.Text="";
            this.txtAG.Text = "";
            this.txtPA1.Text = "";

            this.txtFP_i.Text = "";
            this.txtPF_i.Text = "";
            this.txtFA_i.Text = "";
            this.txtAF_i.Text = "";
            this.txtPA_i.Text = "";
            this.txtAP_i.Text = "";
            this.txtPG_i.Text = "";
            this.txtAG_i.Text = "";
            this.txtPA1_i.Text = "";
            this.txtPA1_g.Text = "";

            this.txtFP_n.Text = "";
            this.txtPF_n.Text = "";
            this.txtFA_n.Text = "";
            this.txtAF_n.Text = "";
            this.txtPA_n.Text = "";
            this.txtAP_n.Text = "";
            this.txtPG_n.Text = "";
            this.txtAG_n.Text = "";
           this.txtPA1_n.Text = "";

            this.txtFP_P.Text = "";
            this.txtPF_F.Text = "";
            this.txtFA_A.Text = "";
            this.txtAF_F.Text = "";
            this.txtPA_A.Text = "";
            this.txtAP_P.Text = "";
            this.txtPG_G.Text = "";
            this.txtAG_G.Text = "";
            this.txtPA1_A1.Text = "";
        }


        private float getPorcentaje(TextBox dato)
        {
            float porcentaje=0;
            try
            {
                porcentaje = float.Parse(dato.Text.Trim());
            }
            catch (Exception err)
            {
                MessageBox.Show("Ingrese datos valido, numericos");
                dato.Text = "1";
                return 1;
            }
            if (porcentaje > 1 || porcentaje<0)
            {
                MessageBox.Show("i y g son valores entre 0 y 1");
                dato.Text = "1";
                return 1;
                
            }
            return porcentaje;
        }

        private float getNumero(TextBox dato)
        {
            float numero = 0;
            try
            {
                numero = float.Parse(dato.Text.Trim());
            }
            catch (Exception err)
            {
                MessageBox.Show("Ingrese datos valido, numericos");
                dato.Text = "0";
                return 0;
            }
            if ( numero < 0)
            {
                MessageBox.Show("Solo valores positivos");
                dato.Text = "0";
                return 0;

            }
            return numero;
        }
        private int getNumero(string  dato)
        {                   
            return int.Parse(dato);
        }
        private int getNumeroEntero(TextBox dato)
        {
            int numero = 0;
            try
            {
                numero = int.Parse(dato.Text.Trim());
            }
            catch (Exception err)
            {
                MessageBox.Show("Ingrese datos valido, numericos");
                dato.Text = "0";
                return 0;
            }
            if (numero < 0)
            {
                MessageBox.Show("Solo valores positivos");
                dato.Text = "0";
                return 0;

            }
            dato.Text = Convert.ToString(numero);
            return numero;
        }
        private double numDecimal(double numero)
        {
            int decimales = getNumero(this.txtNumeroDecimales.Text);
            return Math.Round(numero,decimales);
        }

        private bool noNull(TextBox b1,TextBox b2, TextBox b3)
        {
            if (b1.Text.Trim()!="" && b2.Text.Trim()!="" && b3.Text.Trim()!="")
            {
                return true;
            }
            return false;
        }

        private void btnFP_Click(object sender, EventArgs e)
        {
            if (noNull(this.txtFP_i, this.txtFP_n, this.txtFP_P)) {

                float i = this.getPorcentaje(this.txtFP_i);
                int n = this.getNumeroEntero(this.txtFP_n);
                float P = this.getNumero(this.txtFP_P);
                this.txtFP.Text = Convert.ToString(numDecimal(OO.factorF_P(P, i, n)));
            }          
           
        }

        private void btnPF_Click(object sender, EventArgs e)
        {

            if (noNull(this.txtPF_i, this.txtPF_n, this.txtPF_F))
            {

                float i = this.getPorcentaje(this.txtPF_i);
                int n = this.getNumeroEntero(this.txtPF_n);
                float F = this.getNumero(this.txtPF_F);
                this.txtPF.Text = Convert.ToString(numDecimal(OO.factorP_F(F,i,n)));
            }

        }




        private void btnFA_Click(object sender, EventArgs e)
        {
            if (noNull(this.txtFA_i, this.txtFA_n, this.txtFA_A))
            {
                try { 
                float i = this.getPorcentaje(this.txtFA_i);
                int n = this.getNumeroEntero(this.txtFA_n);
                float A = this.getNumero(this.txtFA_A);
                this.txtFA.Text = Convert.ToString(numDecimal(OO.factorF_A(A, i, n)));
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }
        }

        private void btnAF_Click(object sender, EventArgs e)
        {
            if (noNull(this.txtAF_i, this.txtAF_n, this.txtAF_F))
            {
                try { 
                float i = this.getPorcentaje(this.txtAF_i);
                int n = this.getNumeroEntero(this.txtAF_n);
                float F = this.getNumero(this.txtAF_F);
                this.txtAF.Text = Convert.ToString(numDecimal(OO.factorA_F(F, i, n)));
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }
        }

        private void btnPA_Click(object sender, EventArgs e)
        {
            if (noNull(this.txtPA_i, this.txtPA_n, this.txtPA_A))
            {
                try { 
                float i = this.getPorcentaje(this.txtPA_i);
                int n = this.getNumeroEntero(this.txtPA_n);
                float A = this.getNumero(this.txtPA_A);
                this.txtPA.Text = Convert.ToString(numDecimal(OO.factorP_A(A, i, n)));
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }

        }

        private void btnAP_Click(object sender, EventArgs e)
        {
            if (noNull(this.txtAP_i, this.txtAP_n, this.txtAP_P))
            {
                try { 
                float i = this.getPorcentaje(this.txtAP_i);
                int n = this.getNumeroEntero(this.txtAP_n);
                float P = this.getNumero(this.txtAP_P);
                this.txtAP.Text = Convert.ToString(numDecimal(OO.factorA_P(P, i, n)));
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }
        }



        private void btnPG_Click(object sender, EventArgs e)
        {
            if (noNull(this.txtPG_i, this.txtPG_n, this.txtPG_G))
            {
                try { 
                float i = this.getPorcentaje(this.txtPG_i);
                int n = this.getNumeroEntero(this.txtPG_n);
                float G = this.getNumero(this.txtPG_G);
                this.txtPG.Text = Convert.ToString(numDecimal(OO.factorP_G(G, i, n)));
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }

        }

        private void btnAG_Click(object sender, EventArgs e) //ok
        {
            if (noNull(this.txtAG_i, this.txtAG_n, this.txtAG_G))
            {
                try { 
                float i = this.getPorcentaje(this.txtAG_i);
                int n = this.getNumeroEntero(this.txtAG_n);
                float G = this.getNumero(this.txtAG_G);
                this.txtAG.Text = Convert.ToString(numDecimal(OO.factorA_G(G, i, n)));
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }
        }

        private void btnPA1_Click(object sender, EventArgs e) //ok
        {
            if (noNull(this.txtPA1_i, this.txtPA1_n, this.txtPA1_A1) && this.txtPA1_g.Text.Trim()!="")
            {
                try
                {
                float i = this.getPorcentaje(this.txtPA1_i);
                float g = this.getPorcentaje(this.txtPA1_g);
                int n = this.getNumeroEntero(this.txtPA1_n);
                float A1 = this.getNumero(this.txtPA1_A1);
                this.txtPA1.Text = Convert.ToString(numDecimal(OO.factorP_A1(A1,g,i,n)));
                }catch(Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }

        }
    }
}
