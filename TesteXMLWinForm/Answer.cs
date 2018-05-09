using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TesteXMLWinForm {
    public class Answer {

        private string otherField;
        private string otherField2;
        private Field field;

        public Field Field {
            get { return field; }
            set { field = value; }
        }

        public string OtherField {
             get { return otherField; }
             set { otherField = value; }
         }

         public string OtherField2 {
             get { return otherField2; }
             set { otherField2 = value; }
         }
    }
}
