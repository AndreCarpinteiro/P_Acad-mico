using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Académico.Pedido
{
    public partial class MesaPopup : Form
    {
        public string MesaDestino { get; private set; }
        public MesaPopup()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Verificar se um item foi selecionado na combobox
            if (cbMesa.SelectedIndex != -1)
            {
                // Obter a mesa de destino do item selecionado
                MesaDestino = cbMesa.SelectedItem.ToString();

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma mesa de destino.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
