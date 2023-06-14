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
        private AldersGrupper _aldersgruppe;
        private int _antalDeltagere;

        public enum AldersGrupper
        {
            Pusling, Tumling, Pilt, Væbner, Seniorvæbner
        }
        static Dictionary<int, Boernegruppe> boernegrupper = new Dictionary<int, Boernegruppe>();

        public int Id { get { return _id; } set { _id = value; } }
        public string Navn { get { return _navn; } set { _navn = value; } }
        public AldersGrupper Aldersgruppe { get { return _aldersgruppe; } set { _aldersgruppe = value; } }
        public int AntalDeltagere { get {  return _antalDeltagere; } set { _antalDeltagere = value; } }

        public Boernegruppe(int id, string navn, AldersGrupper aldersgruppe, int antaldeltagere) 
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

        public void CreeateBoernegruppe(Boernegruppe boernegruppe) 
        {

            try
            {

                if (!EksistererBoernegruppe(boernegruppe.Id))
                {
                    boernegrupper.Add(boernegruppe.Id, boernegruppe);
                }
            } catch(Exception e) { Console.WriteLine(e.Message); }
        }

        public Boernegruppe? FindBoernegruppe(int id) 
        {
            //find pr id
            return null;
        }

        public void DeleteBoernegruppe() { }
        public void EditBoernegruppe() { }

        static bool EksistererBoernegruppe(int id) 
        {
            foreach (var bg in boernegrupper)
            {
                if(id == bg.Value.Id) { throw new Exception("En børnegruppe med ID: " + id + " findes allerede. Den indtastede børnegruppe kunne ikke oprettes."); }  
            }
            return false;
        }

    }
}
