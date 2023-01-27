class Program
{
    static void Main()
    {
        Program program = new Program();
        program.CatchException();
    }

    void CatchException()
    {
        try
        {
            CatchAndRethrowExplicitly();
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine("Explicitly specified:{0}{1}",
               Environment.NewLine, e.StackTrace);
        }

        try
        {
            CatchAndRethrowImplicitly();
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine("{0}Implicitly specified:{0}{1}",
               Environment.NewLine, e.StackTrace);
        }
    }

    void CatchAndRethrowExplicitly()
    {
        try
        {
            ThrowException();
        }
        catch (ArithmeticException e)
        {
            // Violates the rule.
            throw e;
        }
    }

    void CatchAndRethrowImplicitly()
    {
        try
        {
            ThrowException();
        }
        catch (ArithmeticException)
        {
            // Satisfies the rule.
            throw;
        }
    }

    void ThrowException()
    {
        throw new ArithmeticException("illegal expression");
    }
}