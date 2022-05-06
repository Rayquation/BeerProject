using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProject
{
    internal class Beer : IComparable
    {
        private string _brewery;
        private string _beerName;
        private BeerType _beertype;
        private int _volume;
        private double _percent;

        public string Brewery
        {
            get { return _brewery; }
            set { _brewery = value; }
        }
        public string BeerName
        {
            get { return _beerName; }
            set { _beerName = value; }
        }
        public BeerType Beertype
        {
            get { return _beertype; }
            set { _beertype = value; }
        }
        public int Volume
        {
            get { return _volume; }
            set { _volume = value; }
        }
        public double Percent
        {
            get { return _percent; }
            set { _percent = value; }
        }
        public Beer()
        {
        }
        public Beer(string brewery,string beername,BeerType beertype,int volume,double percent)
        {
            Brewery = brewery;
            BeerName = beername;
            Beertype = beertype;
            Volume = volume;
            Percent = percent;
        }
        public double GetUnits()
        {
            return (double)Volume * Percent / 150;
        }
        public void add(Beer beer2)
        {
            double result = ((this.Volume * this.Percent + beer2.Volume * beer2.Percent)/(this.Volume+beer2.Volume));
            this.Beertype = BeerType.Mix;
            this.Brewery += beer2.Brewery;
            this.BeerName += beer2.BeerName;
            this.Volume += beer2.Volume;
            this.Percent = result;
        }
        public Beer mix(Beer beer2)
        {
            double result = ((this.Volume * this.Percent + beer2.Volume * beer2.Percent) / (this.Volume + beer2.Volume));
            Beer beer3 = new Beer(this.Brewery + beer2.Brewery, this.BeerName + beer2.BeerName, BeerType.Mix, this.Volume + beer2.Volume, result);
            return beer3;
        }
        public static Beer mix(Beer beer1,Beer beer2)
        {
            double result = ((beer1.Volume * beer1.Percent + beer2.Volume * beer2.Percent) / (beer1.Volume + beer2.Volume));
            Beer beer3 = new Beer(beer1.Brewery + beer2.Brewery, beer1.BeerName + beer2.BeerName, BeerType.Mix, beer1.Volume + beer2.Volume, result);
            return beer3;
        }
        public override string ToString()
        {
            return ($"Brewery:{this.Brewery,-40} BeerName:{this.BeerName,-50} BeerType:{this.Beertype,-10} Volume:{this.Volume,10} Percent:{this.Percent,10:0.000} Units:{GetUnits(),10:0.000}");
        }

        public int CompareTo(object obj)
        {
            return ((int)(this.GetUnits() - ((Beer)obj).GetUnits()));
        }
    }
}
