using System;
using System.Collections.Generic;
using System.Text;

namespace Mechanoid.Parser
{
    public interface DataLoader<T>
    { 
        T ParseDocument(string filePath);
        T[] ParseMultiObjectDocument(string filepath);
    }
}
