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
            List<Boernegruppe> boernegrupper = new List<Boernegruppe>();
            boernegrupper.Add(bg1);
            boernegrupper.Add(bg2);
            foreach (Boernegruppe bg in boernegrupper)
            {
                bg.PrintBoernegruppe();
            }
        }

        private void NyeBoernegrupper() {  }
    }
         
    
}