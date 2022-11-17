using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppPubs.Models;

namespace WindowsAppPubs
{
    public partial class Form1 : Form
    {

        PubsContext DbPubsContext = new PubsContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            List<Publisher> list = DbPubsContext.Publishers.ToList();
            dataGrid1.DataSource = list;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string id = txtIdToInsert.Text;
            if (id.Length > 0)
            {
                Publisher publisher = new Publisher() { pub_id = id, city = "Mendoza", country = "Lujan", pub_name = "Hola!" };
                DbPubsContext.Publishers.Add(publisher);
                int filasAfectadas = DbPubsContext.SaveChanges();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Guardado! Filas afectadas: " + filasAfectadas.ToString());
                    btnTraerTodos_Click(sender, e);
                }
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtIdToDelete.Text;
            Publisher publisherFound = DbPubsContext.Publishers.Find(id);
            if (publisherFound != null)
            {
                DbPubsContext.Publishers.Remove(publisherFound);
                int filasAfectadas = DbPubsContext.SaveChanges();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Eliminado! Filas afectadas: " + filasAfectadas.ToString());
                    btnTraerTodos_Click(sender, e);
                }
            } else
            {
                MessageBox.Show("Ocurrió un error. Probablemente no exista un item con ese ID.");
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtIdToUpdate.Text;
            Publisher publisherFound = DbPubsContext.Publishers.Find(id);
            if (publisherFound != null)
            {
                publisherFound.pub_name = "Este está actualizado";
                publisherFound.city = "Updated";
                publisherFound.country = "Working?";
                int filasAfectadas = DbPubsContext.SaveChanges();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Actualizado! Filas afectadas: " + filasAfectadas.ToString());
                    btnTraerTodos_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Ocurrió un error. Probablemente no exista un item con ese ID.");
            }
        }
    }
}
