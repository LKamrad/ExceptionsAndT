using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exceptions2.Models
{
    internal class RailwayStation
    {

        private string _name;
        private int _waggonsMax;
        private int _waggons;
        private List<Train> _trains = new List<Train>();

        public RailwayStation(string name, int waggons)
        {
            _name = name;
            _waggonsMax = waggons;
            _waggons = 0;
        }

        public void AddTrain(Train tr) 
        {
            if(_waggons + tr.Waggons > _waggonsMax)
            {
                throw new RailwayStationException($"Train can't be added {tr.Zugnummer}");
            } 
            
            _trains.Add(tr);
            _waggons += tr.Waggons;
        }

        public Train SendTrainAway()
        {

            if(_trains.Count > 0)
            {
                Train tr = _trains.First();
                _trains.RemoveAt(0);
                return tr;
            }
            else
            {
                throw new RailwayStationException("No train at the railwaystation!");
            }


        }

        public override string ToString()
        {
            string toReturn = "";

            foreach(Train tr in _trains)
            {
                toReturn += tr.ToString();
                toReturn += "\n";
            }
            return toReturn; 
        }

    }
}
