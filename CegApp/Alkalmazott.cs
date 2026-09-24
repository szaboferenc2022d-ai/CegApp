using System;
using System.Collections.Generic;
using System.Text;

namespace CegApp
{
    internal class Alkalmazott
    {
        public string Nev { get;}
        protected int Alapber { get; }

        public Alkalmazott(string nev, int alapber)
        {
            Nev = nev;
            Alapber = alapber;
        }

        public virtual int FizetesSzamitas()
        {
            return Alapber;
        }

        public override string ToString()
        {
            return $"{Nev}, Fizetés: {FizetesSzamitas()} Ft";
        } 
    }
}
