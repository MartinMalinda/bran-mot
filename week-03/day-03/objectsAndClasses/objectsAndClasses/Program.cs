using System;
using System.Collections.Generic;

namespace objectsAndClasses
{
    class Program
    {
        public static void Main(string[] args)
        {
            SharpieSet mySharpies = new SharpieSet();

            Sharpie broadTip = new Sharpie("pink", 2.5, 0);
            Sharpie fineTip = new Sharpie("blue", 0.5, 1);
            Sharpie chiselTip = new Sharpie("green", 1);

            mySharpies.AddSharpie(broadTip);
            mySharpies.AddSharpie(fineTip);
            mySharpies.AddSharpie(chiselTip);

            mySharpies.CountUsable();
            mySharpies.Removetrash();
        }
    }
}
