using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataMatrix.net;

namespace Datamatrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            DmtxImageEncoder encoder = new DmtxImageEncoder();
            Bitmap img = encoder.EncodeImage(textBoxEnc.Text);
            
            //img.Size = picBox.Size;
            picBox.Image = img;
            picBox.Width = img.Width;
            picBox.Height = img.Height;
            picBox.Left = 139;
            picBox.Top = 95;
            
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            
        }
    }
}
