using System;

namespace SimpleScript
{
    class Lexical
    {
        public String File { get; set; }
        private String[] NameTable;
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

            //TODO: token secundario de palavras nao reservadas
            throw new NotImplementedException();
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