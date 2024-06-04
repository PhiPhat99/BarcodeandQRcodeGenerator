using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;

namespace SyncfusionLab02
{
    public partial class BarcodeQRcodeGenerator : Form
    {
        bool isGenerated = false;
        public BarcodeQRcodeGenerator()
        {
            InitializeComponent();
        }

        private void BarcodeQRcodeGenerator_Load(object sender, EventArgs e)
        {

        }
        private void BarcodeButton_Click(object sender, EventArgs e)
        {
            isGenerated = true;
            GeneratePictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            GeneratePictureBox.Image = barcode.Draw(BarcodeTextBox.Text, 200);
        }

        private void QRButton_Click(object sender, EventArgs e)
        {
            isGenerated = true;
            GeneratePictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            Zen.Barcode.CodeQrBarcodeDraw qrBarcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            GeneratePictureBox.Image = qrBarcode.Draw(QRTextBox.Text, 200);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (isGenerated)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                GeneratePictureBox.Image.Save(path + "\\" + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + ".jpg", ImageFormat.Jpeg);
            }
        }
    }
}
