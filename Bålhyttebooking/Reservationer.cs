using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bålhyttebooking
{
    public class Reservationer
    {
        Dictionary<int, Reservation> reservationer;
        private int _id;

        public Reservationer(int id) 
        {
            _id = id;
            reservationer = new Dictionary<int, Reservation>();
        }

        public int Id { get { return _id; } set { _id = value; } }

        public void RegistrerReservationer(Reservation reservation) 
        {
            reservationer.Add(reservation.Id, reservation);
        }
        public void PrintReservationer() 
        {
            foreach (var r in reservationer)
            {
                r.Value.PrintReservation();
                Console.WriteLine();
            }
        }

        public void FjernReservation(int id)
        {
            reservationer.Remove(id);
        }
    }
    
}
