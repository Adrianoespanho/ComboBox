using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
             
        {
            switch (Convert.ToInt32(cmbEscolhs.SelectedItem))
            {
                case 1:
                    label2.Text = "O més 1 é equivalente a janeiro";
                        break;
                case 2: label2.Text = "O més 2 é equvalente a fevereiro";
                        break;
                case 3:
                    label2.Text = " O més 3 é equivalrnte a março";
                        break;
                        case 4:
                    label2.Text = " O més 4 é equivalrnte a abril";
                        break;
                        case 5:
                    label2.Text = " O més 5 é equivalrnte a maio";
                        break;
                        case 6:
                    label2.Text = " O més 6 é equivalrnte a junho";
                        break;
                        case 7:
                    label2.Text = " O més 7 é equivalrnte a julho";
                        break;
                        case 8:
                    label2.Text = " O més 8 é equivalrnte a agosto"; 
                        break;
                        case 9:
                    label2.Text = " O més 9 é equivalrnte a setembro";
                        break;
                        case 10:
                    label2.Text = " O més 10 é equivalrnte a outubro";
                        break;
                        case 11:
                    label2.Text = " O més 11 é equivalrnte a novembro";
                        break;
                        case 12:
                    label2.Text = " O més 12 é equivalrnte a dezenbro";
                        break;

                        default:
                    label2.Text = "Por favor escolha uma opção de número ; MÉS Não encontrado";
                    break;

           }             
        }

        private void cmbEscolhs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
