using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Note note1 = new Note();
            note1.Fatura = "FATURA";
            note1.tutar = 25;
            note1.seriNo = "AS12";
            note1.faturaTarihi = new DateTime(2015,12,12);
            note1.FaturaDegisti += new FaturaDegistiEventHandler(FaturaDegistiMesajiGöster);
            note1.tutar = 45;
            note1.seriNo = "AS12";
            note1.faturaTarihi = new DateTime(2015, 12, 12);

            Note note2 = new Note();
            note2.Fatura = "FATURA";
            note2.tutar = 25;
            note2.seriNo = "AS12";
            note2.faturaTarihi = DateTime.Now;
            note2.FaturaDegisti += new FaturaDegistiEventHandler(FaturaDegistiMesajiGöster);
            note2.tutar = 25;
            note2.seriNo = "DC45";
            note2.faturaTarihi = DateTime.Now;

            Note note3 = new Note();
            note3.Fatura = "FATURA";
            note3.tutar = 25;
            note3.seriNo = "DC45";
            note3.faturaTarihi = new DateTime(2015, 12, 12);
            note3.FaturaDegisti += new FaturaDegistiEventHandler(FaturaDegistiMesajiGöster);
            note3.tutar = 25;
            note3.seriNo = "DC45";
            note3.faturaTarihi = DateTime.Now;
        }
       

        private void FaturaDegistiMesajiGöster(Note sender, NoteEventArgs e)
        {
            MessageBox.Show($"{sender.Fatura} faturası değişti\nEski Fatura: {e.EskiTutar}  {e.EskiSeriNo}  {e.EskiFaturaTarihi}\n Yeni Fatura: {e.YeniTutar}  {e.YeniSeriNo}  {e.YeniFaturaTarihi}");
        }
    }

}