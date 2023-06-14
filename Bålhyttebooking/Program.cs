using System.Security.Cryptography.X509Certificates;

namespace Bålhyttebooking
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");

            Boernegruppe bg1 = new Boernegruppe(1, "børnegruppe 1", "tumlinge", 23);
            Boernegruppe bg2 = new Boernegruppe(2, "børnegruppe 2", "tumlinge", 23);

            Reservation r1 = new Reservation(1, DateTime.Now, bg1);
            Reservation r2 = new Reservation(2, DateTime.Now, bg2 );

            Reservationer res = new Reservationer(DateTime.Now.Year);

            res.RegistrerReservationer(r1);
            res.RegistrerReservationer(r2);
            res.PrintReservationer();


        }

        private void NyeBoernegrupper() {  }
    }
         
    
}