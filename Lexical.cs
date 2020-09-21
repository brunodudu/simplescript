using System;
using System.Collections.Generic;

namespace SimpleScript
{
    class Lexical
    {
        public String File { get; set; }
        private List<String> IdTable;
        private List<String> StringvalTable;
        private List<int> NumeralTable;
        private List<char> CharTable;
        public Lexical(String file)
        {
            File = file;
        }

        private Token SearchKeyWord(String name)
        {
            var Token = new Token();
            if (name.Equals("array"))
            {
                Token.Primary = PrimaryToken.ARRAY;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("boolean"))
            {
                Token.Primary = PrimaryToken.BOOLEAN;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("break"))
            {
                Token.Primary = PrimaryToken.BREAK;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("char"))
            {
                Token.Primary = PrimaryToken.CHAR;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("continue"))
            {
                Token.Primary = PrimaryToken.CONTINUE;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("do"))
            {
                Token.Primary = PrimaryToken.DO;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("else"))
            {
                Token.Primary = PrimaryToken.ELSE;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("false"))
            {
                Token.Primary = PrimaryToken.FALSE;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("function"))
            {
                Token.Primary = PrimaryToken.FUNCTION;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("if"))
            {
                Token.Primary = PrimaryToken.IF;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("integer"))
            {
                Token.Primary = PrimaryToken.INTEGER;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("of"))
            {
                Token.Primary = PrimaryToken.OF;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("string"))
            {
                Token.Primary = PrimaryToken.STRING;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("struct"))
            {
                Token.Primary = PrimaryToken.STRUCT;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("true"))
            {
                Token.Primary = PrimaryToken.TRUE;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("type"))
            {
                Token.Primary = PrimaryToken.TYPE;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("var"))
            {
                Token.Primary = PrimaryToken.VAR;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("while"))
            {
                Token.Primary = PrimaryToken.WHILE;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals(":"))
            {
                Token.Primary = PrimaryToken.COLON;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals(";"))
            {
                Token.Primary = PrimaryToken.SEMI_COLON;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals(","))
            {
                Token.Primary = PrimaryToken.COMMA;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("["))
            {
                Token.Primary = PrimaryToken.LEFT_SQUARE;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("]"))
            {
                Token.Primary = PrimaryToken.RIGHT_SQUARE;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("{"))
            {
                Token.Primary = PrimaryToken.LEFT_BRACES;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("}"))
            {
                Token.Primary = PrimaryToken.RIGHT_BRACES;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("("))
            {
                Token.Primary = PrimaryToken.LEFT_PARENTHESIS;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals(")"))
            {
                Token.Primary = PrimaryToken.RIGHT_PARENTHESIS;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("&&"))
            {
                Token.Primary = PrimaryToken.AND;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("||"))
            {
                Token.Primary = PrimaryToken.OR;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("<"))
            {
                Token.Primary = PrimaryToken.LESS_THAN;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals(">"))
            {
                Token.Primary = PrimaryToken.GREATER_THAN;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("<="))
            {
                Token.Primary = PrimaryToken.LESS_OR_EQUAL;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals(">="))
            {
                Token.Primary = PrimaryToken.GREATER_OR_EQUAL;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("!="))
            {
                Token.Primary = PrimaryToken.NOT_EQUAL;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("=="))
            {
                Token.Primary = PrimaryToken.EQUAL_EQUAL;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("+"))
            {
                Token.Primary = PrimaryToken.PLUS;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("++"))
            {
                Token.Primary = PrimaryToken.PLUS_PLUS;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("-"))
            {
                Token.Primary = PrimaryToken.MINUS;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("--"))
            {
                Token.Primary = PrimaryToken.MINUS_MINUS;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("*"))
            {
                Token.Primary = PrimaryToken.TIMES;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("/"))
            {
                Token.Primary = PrimaryToken.DIVIDE;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("."))
            {
                Token.Primary = PrimaryToken.DOT;
                Token.Secundary = null;
                return Token;
            }
            if (name.Equals("!"))
            {
                Token.Primary = PrimaryToken.NOT;
                Token.Secundary = null;
                return Token;
            }

            return SearchName(name);
        }

        private Boolean IsNumeral(String name)
        {
            if (name.Length < 1) return false;

            foreach (char c in name)
            {
                if (IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        private Boolean IsDigit(char c)
        {
            if ((int)c < (int)'0' || (int)c > (int)'9') return false;
            else return true;
        }

        private Boolean IsCharacter(char c)
        {
            if ((int)c >= (int)'A' && (int)c <= (int)'Z') return true;
            if ((int)c >= (int)'a' && (int)c <= (int)'z') return true;
            return false;
        }

        private Boolean IsId(String name)
        {
            if (name.Length < 1) return false;

            if (!IsCharacter(name[0])) return false;

            foreach (char c in name)
            {
                if (!IsCharacter(c) && !IsDigit(c)) return false;
            }

            return true;
        }

        private Token SearchName(String name)
        {
            var Token = new Token();
            Token.Secundary = null;
            
            if (name.Length == 3 && name[0] == '\'' && name[2] == '\'')
            {
                Token.Primary = PrimaryToken.CHARACTER;

                var character = name[1];

                for (int i = 0; i < CharTable.Count; i++)
                {
                    if (character == CharTable[i])
                    {
                        Token.Secundary = i;
                        break;
                    }
                }

                if (!Token.Secundary.HasValue)
                {
                    CharTable.Add(character);
                    Token.Secundary = CharTable.Count - 1;
                }
            }
            else if (name[0] == '\"' && name[name.Length-1] == '\"')
            {
                Token.Primary = PrimaryToken.STRINGVAL;

                var stringval = name.Substring(1, name.Length - 2);

                for (int i = 0; i < StringvalTable.Count; i++)
                {
                    if (stringval.Equals(StringvalTable[i]))
                    {
                        Token.Secundary = i;
                        break;
                    }
                }

                if (!Token.Secundary.HasValue)
                {
                    StringvalTable.Add(stringval);
                    Token.Secundary = StringvalTable.Count - 1;
                }
            }
            else if (IsNumeral(name))
            {
                Token.Primary = PrimaryToken.NUMERAL;

                var numeral = Int32.Parse(name);

                for (int i = 0; i < NumeralTable.Count; i++)
                {
                    if (numeral == NumeralTable[i])
                    {
                        Token.Secundary = i;
                        break;
                    }
                }

                if (!Token.Secundary.HasValue)
                {
                    NumeralTable.Add(numeral);
                    Token.Secundary = NumeralTable.Count - 1;
                }
            }
            else if (IsId(name))
            {
                Token.Primary = PrimaryToken.ID;

                for (int i = 0; i < IdTable.Count; i++)
                {
                    if (name.Equals(IdTable[i]))
                    {
                        Token.Secundary = i;
                        break;
                    }
                }

                if (!Token.Secundary.HasValue)
                {
                    IdTable.Add(name);
                    Token.Secundary = IdTable.Count - 1;
                }
            }
            else
            {
                Token.Primary = PrimaryToken.UNKNOWN;
            }

            return Token;
        }

        public char GetCharConst(int SecundaryToken)
        {
            return CharTable[SecundaryToken];
        }

        public String GetStringConst(int SecundaryToken)
        {
            return StringvalTable[SecundaryToken];
        }

        public int GetIntConst(int SecundaryToken)
        {
            return NumeralTable[SecundaryToken];
        }

        public String GetId(int SecundaryToken)
        {
            return IdTable[SecundaryToken];
        }

        public Boolean Analyser()
        {
            int State = 0;
            foreach (char c in File)
            {
                //TODO: Automato
                switch (State)
                {
                    case 0:
                        if (c == ' ' || c == '\t' || c == '\v' || c == '\r'
                            || c == '\n' || c == '\f') State = 0;
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    default:
                        break;
                }
            }   


            throw new NotImplementedException();
        }
    }
}