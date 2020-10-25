using System.Collections.Generic;

namespace SimpleScript
{
	class SyntaticalParser
	{
		private bool Accept(String s)
		{
			return s == "acc";
		}

		private int Shift(String s)
		{
			if (s.Length == 0)
			{
				return -1;
			}

			if (s[0] != 's')
			{
				return -1;
			}

			try
			{
				return int.Parse(s.Substring(1));
			}
			catch (Exception err)
			{
				return -1;
			}
		}

		private int Reduce(String s)
		{
			if (s.Length == 0)
			{
				return -1;
			}

			if (s[0] != 'r')
			{
				return -1;
			}

			try
			{
				return int.Parse(s.Substring(1));
			}
			catch (Exception err)
			{
				return -1;
			}
		}

		public void Run(Syntatical syntatical, String out, Lexical lexer)
		{
			int state = 0;
			Token currentToken = lexer.NextToken();
			NonTerminals nonterminals = new NonTerminals();
			var action = syntatical.actionTable[state][currentToken.Primary];
			// var sem = semantics.NewAnalyser(lexer, out);

			while (!Accept(action))
			{
				state = Shift(action);
				if (state != -1)
				{
					syntatical.stateStack.Push(state);
					currentToken = lexer.NextToken();
					action = syntatical.actionTable[state][currentToken.Primary];
					continue;
				}

				int rule = Reduce(action);
				if (rule != -1)
				{
					var amountToPop = nonterminals.RuleNumberOfTokens[rule-1];
					while (amountToPop > 0)
					{
						syntatical.stateStack.Pop();
						amountToPop = amountToPop - 1;
					}
					var temporaryState = syntatical.stateStack.Peek();
					var leftToken = nonterminals.RuleLeftTokens[rule-1];
					var stateString = syntatical.actionTable[temporaryState][leftToken];
					state = int.Parse(stateString);
					syntatical.stateStack.Push(state);
					action = syntatical.actionTable[state][currentToken];
					// sem.Parse(rule);
					continue;
				}
			}
			// sem.Close();
		}
	}
}