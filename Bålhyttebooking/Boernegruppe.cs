using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bålhyttebooking
{
    public class Boernegruppe
    {
        private int _id;
        private string _navn;
        private string _aldersgruppe;
        private int _antalDeltagere;

        static Dictionary<int, Boernegruppe> boernegrupper;

        public int Id { get { return _id; } set { _id = value; } }
        public string Navn { get { return _navn; } set { _navn = value; } }
        public string Aldersgruppe { get { return _aldersgruppe; } set { _aldersgruppe = value; } }
        public int AntalDeltagere { get {  return _antalDeltagere; } set { _antalDeltagere = value; } }

        public Boernegruppe(int id, string navn, string aldersgruppe, int antaldeltagere) 
        {
            _id = id;
            _navn = navn;
            _aldersgruppe= aldersgruppe;
            _antalDeltagere = antaldeltagere;
        }

        public void PrintBoernegruppe() 
        {
            Console.WriteLine("Børnegruppe: " + _id.ToString() + "\nNavn: " + _navn + "\nAldersgruppe: " + _aldersgruppe + "\nAntal deltagere: " + _antalDeltagere.ToString());
        }

        public void CreateBoernegruppe() { }

        public Boernegruppe? FindBoernegruppe(int id) 
        {
            //find pr id
            return null;
        }

        public void DeleteBoernegruppe() { }
        public void EditBoernegruppe() { }

        public bool EksistererBoernegruppe(int id) 
        {
            //findes den allerede?
            return false;
        }

    }
}
