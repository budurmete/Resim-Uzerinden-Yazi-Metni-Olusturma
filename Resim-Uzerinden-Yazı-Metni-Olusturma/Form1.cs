using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;// bunu ekliyoruz
using System.Windows.Forms;

namespace Resim_Uzerinden_Yazı_Metni_Olusturma
{
    public partial class Form1 : Form
    {
        //1.Aşama  
        //Paket Yöneticisi Konsolunu Açıp Allta bulununan Instal ı kopyalıp yapıştırıyoruz
        //Install-Package Tesseract -Version 4.1.1

        //2. aşama 
        //https://tesseract-ocr.github.io/tessdoc/Data-Files
        //Linkte ki Dosyayı indirip Uygulamının içinde bulunan Degub un içine atıyoruz

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Donustur_Click(object sender, EventArgs e)
        {
           
            if(openFileDialog1.ShowDialog()==DialogResult.OK)// openfileDilog açıldığında tamam 'a tıklanmışsa
            {
                var resim = new Bitmap(openFileDialog1.FileName);//oepnDilfeDialogta Seçmiş Olduğumuz dosya
                var orc = new TesseractEngine("./tessdata","tur");//veri yolu ile kullancağımız dili yazacağız
                var sonuc = orc.Process(resim);
                richTextBox1.Text = sonuc.GetText();
            }
        }
    }
}
