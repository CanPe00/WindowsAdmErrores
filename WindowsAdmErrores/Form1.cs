using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAdmErrores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico = new Medico(txtNombre.Text);
                //Medico medico = new Medico("");
                //Medico medico = new Medico("La Length propiedad devuelve el número de objetos de Char esta instancia, no el número de caracteres Unicode. El motivo es que un carácter Unicode podría representarse mediante más de un Char. Use la System.Globalization.StringInfo clase para trabajar con cada carácter Unicode en lugar de con cada Char.\r\n\r\nEn algunos lenguajes, como C y C++, un carácter NULL indica el final de una cadena. En .NET, un carácter NULL se puede incrustar en una cadena. Cuando una cadena incluye uno o varios caracteres NULL, se incluyen en la longitud de la cadena total. Por ejemplo, en la cadena siguiente, las subcadenas \"abc\" y \"def\" están separadas por un carácter NULO. La Length propiedad devuelve 7, que indica que incluye los seis caracteres alfabéticos, así como el carácter null.");

                MessageBox.Show("Medico creado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
