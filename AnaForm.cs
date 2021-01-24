using Savas.Library.Concrate;
using System;
using System.Windows.Forms;
using Savas.Library.Enum;

namespace Savas.Dekstop
{
    
    public partial class AnaForm : Form
    {
       
        private readonly Oyun _oyun;
        

        public AnaForm()
        { 
            
            InitializeComponent();

            _oyun = new Oyun(UcaksavarPanel, SavasAlaniPanel);
            _oyun.GecenSureDegisti += Oyun_GecenSureDegisti;
        }
     
        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            switch(e.KeyCode)
            {
                case Keys.Enter:
                    _oyun.Baslat();
                    break;
                case Keys.Right:
                    _oyun.UcaksavariHareketEttir(Yon.Saga);
                    break;
                case Keys.Left:
                    _oyun.UcaksavariHareketEttir(Yon.Sola);
                    break;
                case Keys.Space:
                    _oyun.AtesEt();
                    break;

            }
            
        }
        private void Oyun_GecenSureDegisti(object sender, EventArgs e)
        {
            SureLabel.Text = _oyun.GecenSure.ToString(@"m\:ss");
        }
    }
}
