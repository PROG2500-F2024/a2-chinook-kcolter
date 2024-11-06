using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PROG2500_A2_Chinook.Models
{
    public partial class Track
    {
        //getters for Tracks page
        public string TrackDetails { get
            {
                return "Length: " + this.Milliseconds + " ms\nSize: " + this.Bytes + " bytes" +
                    "\nPrice: $" + this.UnitPrice;
            } }

        public string ComposersWithPretext { get
            {
                return "Composer: " + this.Composer;
            } }

    }
}
