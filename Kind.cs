namespace SimpleScript
{
    public enum Kind : int
    {
        KindVar, KindParam, KindFunction, KindField,
        KindArrayType, KindStructType, KindAliasType, KindScalarType,
        KindUniversal,
        KindUndefined = -1
    }
}