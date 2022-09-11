using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Utils.Entita
{
    internal class Luogo
    {
        private LatLng _latlng = new LatLng();
        public LatLng LatLng
        {
            get { return _latlng; }
            set { _latlng = value; }
        }
        
        private string _comune = "";
        public string Comune
        {
            get { return _comune; }
            set { _comune = value; }
        }
        private string _provincia = "";
        public string Provincia
        {
            get { return _provincia; }
            set { _provincia = value; }
        }
        private string _frazione = "";
        public string Frazione
        {
            get { return _frazione; }
            set { _frazione = value; }
        }
        private string _via = "";
        public string Via
        {
            get { return _via; }
            set { _via = value; }
        }
    }

    internal class LatLng 
    {
        private float _lat = 0;
        public float Lat
        {
            get { return _lat; }
            set { _lat = value; }
        }
        private float _lng = 0;
        public float Lng
        {
            get { return _lng; }
            set { _lng = value; }
        }
    }
}
