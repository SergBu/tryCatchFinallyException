try
{
    try
    {
        throw new NotImplementedException();
    }
    catch
    {
        throw new NullReferenceException();
    }
    finally
    {
        throw new DivideByZeroException();
    }
}
catch (Exception e)
{
    //Attempted to divide by zero.
    Console.WriteLine(e.Message.ToString());
}