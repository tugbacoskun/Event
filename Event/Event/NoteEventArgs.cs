using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class NoteEventArgs : EventArgs
    {
        public NoteEventArgs(DateTime eskiFaturaTarihi, DateTime yeniFaturaTarihi)
        {
            EskiFaturaTarihi = eskiFaturaTarihi;
            YeniFaturaTarihi = yeniFaturaTarihi;
        }

        public NoteEventArgs(decimal eskiTutar, decimal yeniTutar)
        {
            EskiTutar = eskiTutar;
            YeniTutar = yeniTutar;
        }

        public NoteEventArgs(string eskiSeriNo, string yeniSeriNo)
        {
            EskiSeriNo = eskiSeriNo;
            YeniSeriNo = yeniSeriNo;
        }

        public DateTime EskiFaturaTarihi { get; }
        public DateTime YeniFaturaTarihi { get; }
        public decimal EskiTutar { get; }
        public decimal YeniTutar { get; }
        public string EskiSeriNo { get; }
        public string YeniSeriNo { get; }
    }
}
