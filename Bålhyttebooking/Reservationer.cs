using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bålhyttebooking
{
    public class Reservationer
    {
        Dictionary<string, Reservation> reservationer;
        private int _id;

        public Reservationer(int id) 
        {
            _id = id;
            reservationer = new Dictionary<string, Reservation>();
        }

        public int Id { get { return _id; } set { _id = value; } }
    }
}
