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
    }
}