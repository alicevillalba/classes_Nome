using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_Nome
{
    public partial class FrmPrefeito : Form
    {
        public FrmPrefeito()
        {
            InitializeComponent();
        }

        private void exibirFormPrefeito_Click(object sender, EventArgs e)
        {
            FrmPrefeito frm = new FrmPrefeito();
            this.Hide();
            frm.ShowDialog();
        }

        private void exibirFormLoja_Click(object sender, EventArgs e)
        {
            FrmLoja frm = new FrmLoja();
            this.Hide();
            frm.ShowDialog();
        }

        private void exibirFormAlimento_Click(object sender, EventArgs e)
        {
            FrmAlimento frm = new FrmAlimento();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
