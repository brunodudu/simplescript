namespace SimpleScript
{
    // Analyser is the semantical analyser
    public class SemanticalAnalyser {
        public Attribute[] Stack { get; set; }
        ScopeAnalyser scope { get; set; }
        Lexical lexer { get; set; }
        public File file { get; set; }
        public int nFuncs { get; set; }
        public int label { get; set; }

        // Close closes the analyser's generated VM code
        public Error Close(SemanticalAnalyser a) {
            a.file.Close();
        }

        // NewAnalyser creates a new analyser
        public SemanticalAnalyser NewAnalyser(Lexical l, string fileName) {
            file = File.Create(fileName);
            SemanticalAnalyser semAnalyser = new SemanticalAnalyser();
            semAnalyser.scope = scope.SemanticalAnalyser;
            semAnalyser.Stack = new Attribute[];
            semAnalyser.file = file;
            semAnalyser.lexer = l;
        }

        // Parse performs a semantical reduction rule parsing logic
        public void Parse(ref SemanticalAnalyser analyser, int r) {
            RuleEnum rule = Rule(r);

            switch (rule) {
                case RuleEnum.P0:
                    break;
                case RuleEnum.LDE0:
                    break;
                case RuleEnum.LDE1:
                    break;
                case RuleEnum.DE0:
                    break;
                case RuleEnum.DE1:
                    break;
                case RuleEnum.T0: // T-> 'integer'
                    var t = TStatic.Attribute.(T);
                    t.Type = scope.PIntObj;

                    TStatic.Size = 1;
                    TStatic.Type = nonterminals.T;
                    TStatic.Attribute = t;

                    a.Push(TStatic);
                    break;
                case RuleEnum.T1: // T -> 'char'
                    var t = TStatic.Attribute.(T);
                    t.Type = scope.PCharObj;

                    TStatic.Size = 1;
                    TStatic.Type = nonterminals.T;
                    TStatic.Attribute = t;

                    a.Push(TStatic);
                    break;
                case RuleEnum.T2: // T -> 'boolean'
                    var t = TStatic.Attribute.(T);
                    t.Type = scope.PBoolObj;

                    TStatic.Size = 1;
                    TStatic.Type = nonterminals.T;
                    TStatic.Attribute = t;

                    a.Push(TStatic);
                    break;
                case RuleEnum.T3: // T -> 'string'
                    var t = TStatic.Attribute.(T);
                    t.Type = scope.PStringObj;

                    TStatic.Size = 1;
                    TStatic.Type = nonterminals.T;
                    TStatic.Attribute = t;

                    a.Push(TStatic);
                    break;
                case RuleEnum.T4: // T -> IDU
                    IDUStatic = a.Top();
                    var id = IDUStatic.Attribute.(ID);
                    p = id.Object;
                    a.Pop();

                    if (p.Kind.IsType() || p.Kind == scope.KindUniversal) {
                        var t = TStatic.Attribute.(T);
                        t.Type = p;
                        TStatic.Attribute = t;

                        if (p.Kind == scope.KindAliasType) {
                            var alias = p.T.(scope.Alias);
                            TStatic.Size = alias.Size;
                        } else if (p.Kind == scope.KindArrayType) {
                            var arr = p.T.(scope.Array);
                            TStatic.Size = arr.Size;
                        } else if (p.Kind == scope.KindStructType) {
                            strcvar t = p.T.(scope.Struct);
                            TStatic.Size = strct.Size;
                        }
                    } else {
                        var t = TStatic.Attribute.(T);
                        t.Type = scope.PUniversalObj;

                        TStatic.Attribute = t;
                        TStatic.Size = 0;
                    }
                    TStatic.Type = nonterminals.T;
                    a.Push(TStatic);
                    break;
                case RuleEnum.DT0: // DT -> 'type' IDD '=' 'array' '[' NUM ']' 'of' T
                    TStatic = a.Top();
                    a.Pop();
                    NUMStatic = a.Top();
                    a.Pop();
                    IDDStatic = a.Top();
                    a.Pop();

                    var id = IDDStatic.Attribute.(ID);
                    var num = NUMStatic.Attribute.(NUM);
                    var typ = TStatic.Attribute.(T);

                    p = id.Object;
                    n = num.Val;
                    t = typ.Type;

                    p.Kind = scope.KindArrayType;
                    break;
                case RuleEnum.DT1: // DT -> 'type' IDD '=' 'struct' NB '{' DC '}'
                    DCStatic = a.Top();
                    a.Pop();
                    IDDStatic = a.Top();
                    a.Pop();

                    var obj = IDDStatic.Attribute.(ID);
                    var dc = DCStatic.Attribute.(DC);
                    p = obj.Object;

                    p.Kind = scope.KindStructType;
                    a.scope.EndBlock();
                    break;
                case RuleEnum.DT2: // DT -> 'type' IDD '=' T
                    TStatic = a.Top();
                    a.Pop();
                    IDDStatic = a.Top();
                    a.Pop();

                    var id = IDDStatic.Attribute.(ID);
                    var typ = TStatic.Attribute.(T);

                    p = id.Object;
                    t = typ.Type;

                    p.Kind = scope.KindAliasType;
                    break;
                case RuleEnum.DC0: // DC -> DC ';' LI ':' T
                    TStatic = a.Top();
                    a.Pop();
                    LIStatic = a.Top();
                    a.Pop();
                    DC1Static = a.Top();
                    a.Pop();

                    var li = LIStatic.Attribute.(LI);
                    var typ = TStatic.Attribute.(T);

                    p = li.List;
                    t = typ.Type;
                    n = DC1Static.Size;
    }
}