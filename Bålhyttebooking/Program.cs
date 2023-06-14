using System;
using System.Security.Cryptography.X509Certificates;

namespace Bålhyttebooking
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");

      

            Boernegruppe bg1 = new Boernegruppe(1, "børnegruppe 1", Boernegruppe.AldersGrupper.Tumling, 23);
            bg1.CreeateBoernegruppe(bg1);
            Boernegruppe bg2 = new Boernegruppe(2, "børnegruppe 2", Boernegruppe.AldersGrupper.Tumling, 23);
            bg2.CreeateBoernegruppe(bg2);

            Reservation r1 = new Reservation(1, new DateTime(2023,06,15,12,00,00), bg1);
            Reservation r2 = new Reservation(2, new DateTime(2023, 06, 15, 14, 00, 00), bg2 );
            Reservation r3 = new Reservation(3, new DateTime(2023, 06, 15, 14, 00, 00), bg2);
            Reservation r4 = new Reservation(2, new DateTime(2023, 06, 15, 14, 00, 00), bg2);

            Reservationer res = new Reservationer(DateTime.Now.Year);
            
            Console.WriteLine(res.ReservationOK(r1));
            res.RegistrerReservationer(r1);
            res.RegistrerReservationer(r2);
            res.PrintReservationer();
            res.RegistrerReservationer(r3);
            Console.WriteLine();
            res.RedigerReservation(new Reservation(2, new DateTime(2023, 06, 15, 12, 00, 00), bg2));
            Console.WriteLine();
            res.RedigerReservation(new Reservation(2, new DateTime(2023, 06, 15, 16, 00, 00), bg2));


        }

        private void NyeBoernegrupper() {  }
    }
         
    
}