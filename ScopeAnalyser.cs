using System.Collections.Generic;

namespace SimpleScript
{
    class ScopeAnalyser
    {
        public int Level { get; set; }
        public ScopeObject[] SymbolTable = new ScopeObject[64];
    }
}