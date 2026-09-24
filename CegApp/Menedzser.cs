using System;
using System.Collections.Generic;
using System.Text;

namespace CegApp
{
    internal class Menedzser : Alkalmazott
    {
        public int Bonusz { get; }
        public Menedzser(int bonusz) : base(nev, alapber)
        {
            Bonusz = bonusz;
        }
    }
}
