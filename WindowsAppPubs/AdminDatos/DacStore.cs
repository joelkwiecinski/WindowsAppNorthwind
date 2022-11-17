using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppPubs.Models;

namespace WindowsAppPubs.AdminDatos
{
    public static class DacStore
    {

        public static PubsContext context = new PubsContext();  

        public static List<Store> Lista()
        {
            List<Store> lista = context.Stores.ToList();
            return lista;
        }

        public static Store TraerUno(string id)
        {
            Store storeFound = context.Stores.Find(id);
            return storeFound;
        }

        public static int Nuevo(Store store)
        {
            if (store != null)
            {
                context.Stores.Add(store);
                int filasAfectadas = context.SaveChanges();
                return filasAfectadas;
            } else
            {
                return 0;
            }
        }

        public static int Modificar(Store store)
        {
            if (store != null)
            {
                Store storeDB = context.Stores.Find(store.stor_id);
                storeDB = store;
                int filasAfectadas = context.SaveChanges();
                return filasAfectadas;
            } else
            {
                return 0;
            }
        }

        public static int Eliminar(Store store)
        {
            if (store != null)
            {
                context.Stores.Remove(store);
                int filasAfectadas = context.SaveChanges();
                return filasAfectadas;
            }
            else
            {
                return 0;
            }
        }

    }
}
