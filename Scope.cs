using System.Collections.Generic;

namespace SimpleScript
{
    class Scope
    {
        public bool IsType(Kind k)
        {
            return k == Kind.KindArrayType
                || k == Kind.KindStructType
		        || k == Kind.KindAliasType
		        || k == Kind.KindScalarType;
        }

        public int NewBlock(ScopeAnalyser a)
        {
            a.Level++;
            a.SymbolTable[a.Level] = null;
            return a.Level;
        }

        public int EndBlock(ScopeAnalyser a)
        {
            a.Level--;
            return a.Level;
        }

        public ScopeObject DefineSymbol(ScopeAnalyser a, int name)
        {
            ScopeObject obj = new ScopeObject();
            obj.Name = name;
            obj.Kind = Kind.KindUndefined;
            obj.Next = a.SymbolTable[a.Level];
            a.SymbolTable[a.Level] = obj;
            return obj;
        }

        public ScopeObject SearchLocalSymbol(ScopeAnalyser a, int name)
        {
            ScopeObject obj = a.SymbolTable[a.Level];

            while (obj != null)
            {
                if (obj.Name = name)
                {
                    return obj;
                }
                obj = obj.Next;
            }
            return obj;
        }

        public ScopeObject SearchGlobalSymbol(ScopeAnalyser a, int name)
        {
            ScopeObject obj = new ScopeObject();
            for (int i = a.Level; i>=0; i--)
            {
                obj = a.SymbolTable[i];
                while (obj != null)
                {
                    if (obj.Name = name)
                    {
                        return obj;
                    }
                    obj = obj.Next;
                }
            }

            return obj;
        }
    }
}