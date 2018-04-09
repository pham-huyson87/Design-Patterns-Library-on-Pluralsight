using System.Collections.Generic;

namespace Interpreter.Template
{
    class NonTerminalExpressionList : IExpression
    {
        private List<NonTerminalExpressionA> nonTerminalExpressionList;
        private TerminalExpressionA terminalExpressionA;
        private TerminalExpressionB terminalExpressionB;

        public NonTerminalExpressionList(   List<NonTerminalExpressionA> nonTerminalExpressionList, 
                                            TerminalExpressionA terminalExpressionA,
                                            TerminalExpressionB terminalExpressionB)
        {
            this.nonTerminalExpressionList = nonTerminalExpressionList;
            this.terminalExpressionA = terminalExpressionA;
            this.terminalExpressionB = terminalExpressionB;
        }

        public void Interpret(Context context)
        {
            foreach (var expression in nonTerminalExpressionList)
            {
                expression.Interpret(context);
            }

            terminalExpressionA.Interpret(context);

            terminalExpressionB.Interpret(context);
        }
    }
}
