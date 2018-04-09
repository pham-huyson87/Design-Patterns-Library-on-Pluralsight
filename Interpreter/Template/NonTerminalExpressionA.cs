namespace Interpreter.Template
{
    class NonTerminalExpressionA : IExpression
    {
        private TerminalExpressionC terminalExpressionC;

        public NonTerminalExpressionA(TerminalExpressionC terminalExpressionC)
        {
            this.terminalExpressionC = terminalExpressionC;
        }

        public void Interpret(Context context)
        {
            terminalExpressionC.Interpret(context);
        }
    }
}
