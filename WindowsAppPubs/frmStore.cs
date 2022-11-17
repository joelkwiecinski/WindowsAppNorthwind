using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppPubs.AdminDatos;
using WindowsAppPubs.Models;
using static System.Windows.Forms.AxHost;

namespace WindowsAppPubs
{
    public partial class frmStore : Form
    {
        public frmStore()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataGrid1.DataSource = DacStore.Lista();
        }

        private void btnTraerUno_Click(object sender, EventArgs e)
        {
            List<Store> lista = new List<Store>() { DacStore.TraerUno(txtTraerUno.Text) };
            dataGrid1.DataSource = lista;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Store nuevo = new Store() { city = "Mendoza", state = "LJ", stor_id = txtNuevo.Text, stor_name = "GameMax" };
            if (DacStore.Nuevo(nuevo) > 0)
            {
                MessageBox.Show("Creado con éxito.");
            } else
            {
                MessageBox.Show("Hubo un error.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Store modify = DacStore.TraerUno(txtModificar.Text);
            if (modify != null)
            {
                modify.stor_address = "Viamonte 3432";
                modify.city = "Buenos Aires";
                modify.stor_name = "Pailukir";
                if (DacStore.Modificar(modify) > 0)
                {
                    MessageBox.Show("Modificado con éxito.");
                } else
                {
                    MessageBox.Show("Hubo un error al realizar la modificación.");
                }
            } else
            {
                MessageBox.Show("Parece que ese ID no existe.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Store toDelete = DacStore.TraerUno(txtEliminar.Text);
            if (toDelete != null)
            {
                if (DacStore.Eliminar(toDelete) > 0)
                {
                    MessageBox.Show("Eliminado con éxito.");
                } else
                {
                    MessageBox.Show("Hubo un error al eliminar de la base de datos.");
                }
            }
            else
            {
                MessageBox.Show("Parece que ese ID no existe.");
            }
        }
    }
}
