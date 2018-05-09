using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteXMLWinForm {
   public class Field {

        private List<Item> items;

        public List<Item> Items{
         get { return items; }
         set { items = value; }
        }
    }
}
