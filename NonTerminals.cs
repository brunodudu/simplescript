using System.Collections.Generic;

namespace SimpleScript
{
    class NonTerminals
    {
        public List<Symbol> RuleLeftTokens = new List<int> 
        {Symbol.P, Symbol.LDE, Symbol.LDE, Symbol.DE, Symbol.DE, Symbol.T, Symbol.T, Symbol.T, Symbol.T, Symbol.T, Symbol.DT, Symbol.DT, Symbol.DT, Symbol.DC, Symbol.DC, Symbol.DF, Symbol.LP, Symbol.LP, Symbol.B, Symbol.LDV, Symbol.LDV, Symbol.LS, Symbol.LS, Symbol.DV, Symbol.LI, Symbol.LI, Symbol.S, Symbol.S, Symbol.U, Symbol.U, Symbol.M, Symbol.M, Symbol.M, Symbol.M, Symbol.M, Symbol.M, Symbol.M, Symbol.E, Symbol.E, Symbol.E, Symbol.L, Symbol.L, Symbol.L, Symbol.L, Symbol.L, Symbol.L, Symbol.L, Symbol.R, Symbol.R, Symbol.R, Symbol.Y, Symbol.Y, Symbol.Y, Symbol.F, Symbol.F, Symbol.F, Symbol.F, Symbol.F, Symbol.F, Symbol.F, Symbol.F, Symbol.F, Symbol.F, Symbol.F, Symbol.F, Symbol.F, Symbol.F, Symbol.LE, Symbol.LE, Symbol.LV, Symbol.LV, Symbol.LV, Symbol.IDD, Symbol.IDU, Symbol.ID, Symbol.TRUE, Symbol.FALSE, Symbol.CHR, Symbol.STR, Symbol.NUM, Symbol.NB, Symbol.MF, Symbol.MC, Symbol.NF, Symbol.MT, Symbol.ME, Symbol.MW};

        public List<int> RuleNumberOfTokens = new List<int>
        {1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 9, 8, 4, 5, 3, 10, 5, 3, 4, 2, 1, 2, 1, 5, 3, 1, 1, 1, 6, 9, 9, 7, 8, 2, 4, 2, 2, 3, 3, 1, 3, 3, 3, 3, 3, 3, 1, 3, 3, 1, 3, 3, 1, 1, 2, 2, 2, 2, 3, 5, 2, 2, 1, 1, 1, 1, 1, 3, 1, 3, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0};
    }
}