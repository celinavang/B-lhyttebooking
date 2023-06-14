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
            try
            {
                if (ReservationOK(reservation))
                {
                    reservationer.Add(reservation.Id, reservation);
                }
            } catch (Exception e) 
            { 
                Console.WriteLine(e.Message);
                reservation.PrintReservation();
            }
            
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

        public int AntalReservationer(Boernegruppe boernegruppe) 
        {
            int counter = 0;

            foreach (var r in reservationer)
            {
                if(r.Value.Boernegruppe == boernegruppe)
                {
                    counter++;
                }
            }
            return counter;
        }

        public bool ReservationLedig(DateTime tidspunkt)
        {
            foreach(var r in reservationer)
            {
                if(r.Value.Tidspunkt == tidspunkt)
                {
                    return false;
                }
            } return true;
        }

        public bool ReservationsTidspunktOK(DateTime tidspunkt) 
        {
            if (tidspunkt.Year == _id && tidspunkt.DayOfWeek == DayOfWeek.Thursday && tidspunkt.Hour%2 == 0 && tidspunkt.Minute == 0 && tidspunkt.Second == 0 && tidspunkt.Millisecond == 0)
            {
                return true;
            } else return false;
        }

        public bool ReservationOK(Reservation reservation) 
        {
            if (reservation.Boernegruppe != null && AntalReservationer(reservation.Boernegruppe) < 2 && ReservationLedig(reservation.Tidspunkt) && ReservationsTidspunktOK(reservation.Tidspunkt)) { return true; } 
            else throw new Exception("Følgende reservation er ikke gyldig, og kunne ikke oprettes:");
        }
        
        public Reservation FindReservation(int id)
        {
            foreach (var r in reservationer)
            {
                if (r.Value.Id==id) { return r.Value; }
            } return null;
            
        }

        public void RedigerReservation(Reservation reservation)
        {
            
                if (FindReservation(reservation.Id) != null)
                {
                    if (FindReservation(reservation.Id).Tidspunkt != reservation.Tidspunkt)
                    {
                    if (ReservationLedig(reservation.Tidspunkt) && reservation.Boernegruppe != null && ReservationsTidspunktOK(reservation.Tidspunkt))
                    {
                        reservationer.Remove(reservation.Id);
                        reservationer.Add(reservation.Id, reservation);
                        Console.WriteLine("Reservation opdateret");
                        reservation.PrintReservation();
                        return;
                    }
                    else { Console.WriteLine("En anden booking findes på det valgte tidspunkt"); return; } 
                    } else if (reservation.Boernegruppe != null)
                    {
                        reservationer.Remove(reservation.Id);
                        reservationer.Add(reservation.Id, reservation);
                    Console.WriteLine("Reservation opdateret");
                    reservation.PrintReservation();
                    return;
                    }
                } else { Console.WriteLine("Reservationen findes ikke"); return; }
        }
    }
    
}
