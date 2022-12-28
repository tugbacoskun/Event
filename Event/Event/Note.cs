using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class Note
    {
        public event FaturaDegistiEventHandler FaturaDegisti;
        public string Fatura { get; set; }

        private DateTime FaturaTarihi;

        public DateTime faturaTarihi
        {
            get { return FaturaTarihi; }
            set
            {
                var eskiFaturaTarihi = faturaTarihi;
                FaturaTarihi = value;
                FaturaDegisti?.Invoke(this, new NoteEventArgs(eskiFaturaTarihi, FaturaTarihi));
            }
        }

        private decimal Tutar;

        public decimal tutar
        {
            get { return Tutar; }
            set 
            {
                var eskiTutar = tutar;
                Tutar = value; 
                FaturaDegisti?.Invoke(this, new NoteEventArgs(eskiTutar, Tutar));
            }
        }

        private string SeriNo;

        public string seriNo
        {
            get { return SeriNo; }
            set 
            { 
                var eskiSeriNo=seriNo;
                SeriNo = value; 
                FaturaDegisti?.Invoke(this, new NoteEventArgs(eskiSeriNo, SeriNo));
            }
        }      
    }
}
