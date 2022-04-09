using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(TextQR.Text, QRCodeGenerator.ECCLevel.H);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(30);
                PanelQR.BackgroundImage = new Bitmap(qrCodeImage);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fallo de QR");
            }

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                Image imagenQR = PanelQR.BackgroundImage;

                imagenQR.Save("QR.png", ImageFormat.Png);
                MessageBox.Show("Imagen Guardada");

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se ha podido guardar la imagen");
            }
               
        }
    }
}
