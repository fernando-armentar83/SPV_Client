using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPV_Client
{
    public class ComboBoxItem
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public ComboBoxItem(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
