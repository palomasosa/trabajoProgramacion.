using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajoProgramacion3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int contadorMaK = 0;
        int contadorKaM = 0;
        private void btnMillasKm_Click(object sender, EventArgs e)
        {
            if (numberCalc.Value == 0)
            {
                lblError.Visible = true;

            }
            else
            {
                lblError.Visible = false;
                lblResultado.Text = "";
                double resultado = System.Convert.ToDouble(numberCalc.Value);
                resultado = resultado * 1.609;
                lblResultado.Text = "El resultado es: " + resultado + "km";
                lblResultado.Visible = true;

                
                bool banderaMaK = false;
                while (banderaMaK == false)
                {
                    lblConsultasMaK.Visible = true;
                    lblContadorMaK.Visible = true;
                    contadorMaK = contadorMaK + 1;
                    lblContadorMaK.Text = System.Convert.ToString(contadorMaK);
                    banderaMaK = true;

                }
                
            }
        }

        private void btnKmMillas_Click(object sender, EventArgs e)
        {

            if (numberCalc.Value == 0)
            {
                lblError.Visible = true;

            }
            else
            {
                lblError.Visible = false;
                lblResultado.Text = "";
                double resultado = System.Convert.ToDouble(numberCalc.Value);
                resultado = resultado / 1.609;
                lblResultado.Text = "El resultado es: " + resultado + "mi";
                lblResultado.Visible = true;

                bool banderaKaM = false;
                while (banderaKaM == false)
                {
                    lblConsultasKaM.Visible = true;
                    lblContadorKaM.Visible = true;
                    contadorKaM = contadorKaM + 1;
                    lblContadorKaM.Text = System.Convert.ToString(contadorKaM);
                    banderaKaM = true;

                }
            }
        }


    }
}
