using System.Collections.Generic;

namespace SimpleScript
{
    class ScopeAnalyser
    {
        public int Level { get; set; }
        public List<ScopeObject> SymbolTable { get; set; }
    }
}