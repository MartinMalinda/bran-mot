using System;
using System.Collections.Generic;
using day05.Models;

namespace day05.Interfaces
{
    public interface IFox
    {
        void AddFox(string name);
        void ChangeFox(string name);
        void CheckFox(string name);
        Fox GetCurrentFox();
    }
}
