namespace SimpleScript
{
    public enum PrimaryToken
    {
        // reserved words
        ARRAY, BOOLEAN, BREAK, CHAR, CONTINUE, DO, ELSE, FALSE, FUNCTION,
        IF, INTEGER,  OF, STRING, STRUCT,  TRUE,  TYPE, VAR, WHILE,
        
        //symbols
        COLON, SEMI_COLON, COMMA, EQUALS, LEFT_SQUARE, RIGHT_SQUARE, LEFT_BRACES,
        RIGHT_BRACES, LEFT_PARENTHESIS, RIGHT_PARENTHESIS, AND, OR,  LESS_THAN,
        GREATER_THAN, LESS_OR_EQUAL, GREATER_OR_EQUAL, NOT_EQUAL,  EQUAL_EQUAL,
        PLUS, PLUS_PLUS, MINUS, MINUS_MINUS, TIMES, DIVIDE, DOT, NOT,
        
        //regular tokens
        CHARACTER, NUMERAL, STRINGVAL, ID,
        
        //unknown token
        UNKNOWN
    }
}