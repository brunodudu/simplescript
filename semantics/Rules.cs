namespace SimpleScript
{
    // Rule enumerates all rules
    public class Rule {
        // All rules enumeration
        public enum RuleEnum {
            PLINE0,
            P0,
            LDE0,
            LDE1,
            DE0,
            DE1,
            T0,
            T1,
            T2,
            T3,
            T4,
            DT0,
            DT1,
            DT2,
            DC0,
            DC1,
            DF0,
            LP0,
            LP1,
            B0,
            LDV0,
            LDV1,
            LS0,
            LS1,
            DV0,
            LI0,
            LI1,
            S0,
            S1,
            U0,
            U1,
            M0,
            M1,
            M2,
            M3,
            M4,
            M5,
            M6,
            E0,
            E1,
            E2,
            L0,
            L1,
            L2,
            L3,
            L4,
            L5,
            L6,
            R0,
            R1,
            R2,
            Y0,
            Y1,
            Y2,
            F0,
            F1,
            F2,
            F3,
            F4,
            F5,
            F6,
            F7,
            F8,
            F9,
            F10,
            F11,
            F12,
            F13,
            LE0,
            LE1,
            LV0,
            LV1,
            LV2,
            IDD0,
            IDU0,
            ID0,
            TRUE0,
            FALSE0,
            CHR0,
            STR0,
            NUM0,
            NB0,
            MF0,
            MC0,
            NF0,
            MT0,
            ME0,
            MW0
        }

        public string GetString(RuleEnum r){
            switch (r) {
            case RuleEnum.PLINE0:
                return "PLINE0";
            case RuleEnum.P0:
                return "P0";
            case RuleEnum.LDE0:
                return "LDE0";
            case RuleEnum.LDE1:
                return "LDE1";
            case RuleEnum.DE0:
                return "DE0";
            case RuleEnum.DE1:
                return "DE1";
            case RuleEnum.T0:
                return "T0";
            case RuleEnum.T1:
                return "T1";
            case RuleEnum.T2:
                return "T2";
            case RuleEnum.T3:
                return "T3";
            case RuleEnum.T4:
                return "T4";
            case RuleEnum.DT0:
                return "DT0";
            case RuleEnum.DT1:
                return "DT1";
            case RuleEnum.DT2:
                return "DT2";
            case RuleEnum.DC0:
                return "DC0";
            case RuleEnum.DC1:
                return "DC1";
            case RuleEnum.DF0:
                return "DF0";
            case RuleEnum.LP0:
                return "LP0";
            case RuleEnum.LP1:
                return "LP1";
            case RuleEnum.B0:
                return "B0";
            case RuleEnum.LDV0:
                return "LDV0";
            case RuleEnum.LDV1:
                return "LDV1";
            case RuleEnum.LS0:
                return "LS0";
            case RuleEnum.LS1:
                return "LS1";
            case RuleEnum.DV0:
                return "DV0";
            case RuleEnum.LI0:
                return "LI0";
            case RuleEnum.LI1:
                return "LI1";
            case RuleEnum.S0:
                return "S0";
            case RuleEnum.S1:
                return "S1";
            case RuleEnum.U0:
                return "U0";
            case RuleEnum.U1:
                return "U1";
            case RuleEnum.M0:
                return "M0";
            case RuleEnum.M1:
                return "M1";
            case RuleEnum.M2:
                return "M2";
            case RuleEnum.M3:
                return "M3";
            case RuleEnum.M4:
                return "M4";
            case RuleEnum.M5:
                return "M5";
            case RuleEnum.M6:
                return "M6";
            case RuleEnum.E0:
                return "E0";
            case RuleEnum.E1:
                return "E1";
            case RuleEnum.E2:
                return "E2";
            case RuleEnum.L0:
                return "L0";
            case RuleEnum.L1:
                return "L1";
            case RuleEnum.L2:
                return "L2";
            case RuleEnum.L3:
                return "L3";
            case RuleEnum.L4:
                return "L4";
            case RuleEnum.L5:
                return "L5";
            case RuleEnum.L6:
                return "L6";
            case RuleEnum.R0:
                return "R0";
            case RuleEnum.R1:
                return "R1";
            case RuleEnum.R2:
                return "R2";
            case RuleEnum.Y0:
                return "Y0";
            case RuleEnum.Y1:
                return "Y1";
            case RuleEnum.Y2:
                return "Y2";
            case RuleEnum.F0:
                return "F0";
            case RuleEnum.F1:
                return "F1";
            case RuleEnum.F2:
                return "F2";
            case RuleEnum.F3:
                return "F3";
            case RuleEnum.F4:
                return "F4";
            case RuleEnum.F5:
                return "F5";
            case RuleEnum.F6:
                return "F6";
            case RuleEnum.F7:
                return "F7";
            case RuleEnum.F8:
                return "F8";
            case RuleEnum.F9:
                return "F9";
            case RuleEnum.F10:
                return "F10";
            case RuleEnum.F11:
                return "F11";
            case RuleEnum.F12:
                return "F12";
            case RuleEnum.F13:
                return "F13";
            case RuleEnum.LE0:
                return "LE0";
            case RuleEnum.LE1:
                return "LE1";
            case RuleEnum.LV0:
                return "LV0";
            case RuleEnum.LV1:
                return "LV1";
            case RuleEnum.LV2:
                return "LV2";
            case RuleEnum.IDD0:
                return "IDD0";
            case RuleEnum.IDU0:
                return "IDU0";
            case RuleEnum.ID0:
                return "ID0";
            case RuleEnum.TRUE0:
                return "TRUE0";
            case RuleEnum.FALSE0:
                return "FALSE0";
            case RuleEnum.CHR0:
                return "CHR0";
            case RuleEnum.STR0:
                return "STR0";
            case RuleEnum.NUM0:
                return "NUM0";
            case RuleEnum.NB0:
                return "NB0";
            case RuleEnum.MF0:
                return "MF0";
            case RuleEnum.MC0:
                return "MC0";
            case RuleEnum.NF0:
                return "NF0";
            case RuleEnum.MT0:
                return "MT0";
            case RuleEnum.ME0:
                return "ME0";
            case RuleEnum.MW0:
                return "MW0";
            default:
                return "";
            }
        }
    }
}