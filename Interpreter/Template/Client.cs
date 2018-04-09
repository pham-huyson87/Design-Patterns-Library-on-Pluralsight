using System.Collections.Generic;

namespace Interpreter.Template
{
    class Client
    {
        public Client()
        {
            IExpression expression = new NonTerminalExpressionList(
                new List<NonTerminalExpressionA>() {
                    new NonTerminalExpressionA(new TerminalExpressionC()),
                    new NonTerminalExpressionA(new TerminalExpressionC())
                },
                new TerminalExpressionA(),
                new TerminalExpressionB()
              );

            expression.Interpret(new Context());
        }
    }
}
