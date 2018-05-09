using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace TesteXMLWinForm {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        // SERIALIZAR
        private void btnS_Click(object sender, EventArgs e) {

            try {
                OpenFileDialog openFile = new OpenFileDialog();
                if (openFile.ShowDialog() == DialogResult.OK) {
                    var path = openFile.FileName;

                    XmlSerializer serializer = new XmlSerializer(typeof(Answer));
                    StreamReader reader = new StreamReader(path);

                    var input = serializer.Deserialize(reader);
                    reader.Close();
                    dgXml.DataSource = input;
                }
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }


        // DESERIALIZAR
        private void btnD_Click(object sender, EventArgs e) {
            try {
                SaveFileDialog saveFile = new SaveFileDialog();
                if (saveFile.ShowDialog() == DialogResult.OK) {
                    var path = saveFile.FileName;

                    XmlSerializer serializer = new XmlSerializer(typeof(Answer));
                    StreamWriter writer = new StreamWriter(path);

                    serializer.Serialize(writer, dgXml.DataSource);
                    writer.Close();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }


        // Sair
        private void btnSair_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }
    }
}
