namespace SimpleScript
{
    public interface Obj {
        void attributeObJ(int type);
    }
    public class Attribute {
        public int Type { get; set; }
        public int Size { get; set; }
        public Obj attribute { get; set; }
    }
    
    public class Types {
        public string GetString(Attribute a) {
            switch (a.attribute.attributeObj(a.Type)) {
            case ID:
                return "ID";
            case T:
                return "T";
            case E:
                return "E";
            case L:
                return "L";
            case R:
                return "R";
            case Y:
                return "Y";
            case F:
                return "F";
            case LV:
                return "LV";
            case MC:
                return "MC";
            case MT:
                return "MT";
            case ME:
                return "ME";
            case MW:
                return "MW";
            case MA:
                return "MA";
            case LE:
                return "LE";
            case LI:
                return "LI";
            case DC:
                return "DC";
            case LP:
                return "LP";
            case TRUE:
                return "TRUE";
            case FALSE:
                return "FALSE";
            case CHR:
                return "CHR";
            case STR:
                return "STR";
            case NUM:
                return "NUM";
            }
            return "";
        }

        public Types() {
            IDDStatic.attribute = new ID();
            IDUStatic.attribute = new ID();
            IDStatic.attribute = new ID();
            TStatic.attribute = new T();
            LIStatic.attribute = new LI();
            LI0Static.attribute = new LI();
            LI1Static.attribute = new LI();
            TRUStatic.attribute = new TRUE();
            FALSStatic.attribute = new FALSE();
            STRStatic.attribute = new STR();
            CHRStatic.attribute = new CHR();
            NUMStatic.attribute = new NUM();
            DCStatic.attribute = new DC();
            DC0Static.attribute = new DC();
            DC1Static.attribute = new DC();
            LPStatic.attribute = new LP();
            LP0Static.attribute = new LP();
            LP1Static.attribute = new LP();
            EStatic.attribute = new E();
            E0Static.attribute = new E();
            E1Static.attribute = new E();
            LStatic.attribute = new L();
            L0Static.attribute = new L();
            L1Static.attribute = new L();
            RStatic.attribute = new R();
            R0Static.attribute = new R();
            R1Static.attribute = new R();
            YStatic.attribute = new Y();
            Y0Static.attribute = new Y();
            Y1Static.attribute = new Y();
            FStatic.attribute = new F();
            F0Static.attribute = new F();
            F1Static.attribute = new F();
            LVStatic.attribute = new LV();
            LV0Static.attribute = new LV();
            LV1Static.attribute = new LV();
            MCStatic.attribute = new MC();
            LEStatic.attribute = new LE();
            LE0Static.attribute = new LE();
            LE1Static.attribute = new LE();
            MTStatic.attribute = new MT();
            MEStatic.attribute = new ME();
            MWStatic.attribute = new MW();
        }

        Attribute IDDStatic, IDUStatic, IDStatic, TStatic, LIStatic, LI0Static, LI1Static, TRUStatic, FALSStatic, STRStatic, CHRStatic, NUMStatic, DCStatic, DC0Static, DC1Static, LPStatic, LP0Static, LP1Static, EStatic, E0Static, E1Static, LStatic, L0Static, L1Static, RStatic, R0Static, R1Static, YStatic, Y0Static, Y1Static, FStatic, F0Static, F1Static, LVStatic, LV0Static, LV1Static, MCStatic, LEStatic, LE0Static, LE1Static, MTStatic, MEStatic, MWStatic, NBStatic;

        ScopeObject p, t, f;
        
        int name, n, l, l1, l2;
        int functionVarPos;
        ScopeObject curFunction;
    }


    public class ID {
        public Object ScopeObject { get; set; }
        public int Name  { get; set; }
    }

    public class T {
        public ScopeObject Type { get; set; }
    }
  
    public class E {
        public ScopeObject Type { get; set; }
    }

    public class L {
        public ScopeObject Type { get; set; }
    }

    public class R {
        public ScopeObject Type { get; set; }
    }

    public class Y {
        public ScopeObject Type { get; set; }
    }

    public class F {
        public ScopeObject Type { get; set; }
    }

    public class LV {
        public ScopeObject Type { get; set; }
    }

    public class MC {
        public ScopeObject Type { get; set; }
        public ScopeObject Param { get; set; }
        public int Err { get; set; }
    }
    
    public class MT {
        public int Label { get; set; }
    }

    public class ME {
        public int Label { get; set; }
    }
    

    public class MW {
        public int Label { get; set; }
    }

    public class MA {
        public int Label { get; set; }
    }

    public class LE {
        public ScopeObject Type { get; set; }
        public ScopeObject Param { get; set; }
        public int Err { get; set; }
        public int N { get; set; }
    }

    public class LI {
        public ScopeObject List { get; set; }
    }

    public class DC {
        public ScopeObject List { get; set; }
    }

    public class LP {
        public ScopeObject List { get; set; }
    }
    
    public class TRUE {
        public ScopeObject Type { get; set; }
        public int Val { get; set; }
    }

    public class FALSE {
        public ScopeObject Type { get; set; }
        public int Val { get; set; }
    }

    public class CHR {
        public ScopeObject Type { get; set; }
        public int Pos { get; set; }
        public char Val { get; set; }
    }

    public class STR {
        public ScopeObject Type { get; set; }
        public int Pos { get; set; }
        public string Val { get; set; }
    }

    public class NUM {
        public ScopeObject Type { get; set; }
        public int Pos { get; set; }
        public int Val { get; set; }
    }
    
}