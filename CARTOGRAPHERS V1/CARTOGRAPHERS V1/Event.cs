using System;
using System.Collections.Generic;
using System.Text;

namespace CARTOGRAPHERS_V1
{
    class Event
    {
        private int id;
        private int timeCost;
        public string Title;



        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public int TimeCost
        {
            get
            {
                return timeCost;
            }
            set
            {
                timeCost = value;
            }
        }

        public Event(int id, int tc, string name)
        {
            ID = id;
            TimeCost = tc;
            Title = name;
        }

    }
}
