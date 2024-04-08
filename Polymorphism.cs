public interface IClassA
{
    void DisplayMessage();
}

public class ClassB : IClassA
{
    public void DisplayMessage()
    {
        Console.WriteLine("Class B method.");
    }
}

public class ClassC : IClassA
{
    public void DisplayMessage()
    {
        Console.WriteLine("Class C method.");
    }
}

public class ClassA
{
    IClassA _classInstance;

    public ClassA(IClassA classInstance){
        _classInstance = classInstance;
    }

    public ClassA(int value)
    {
        switch (value)
        {
            case 0:
                _classInstance = new ClassB();
                break;
            case 1:
                _classInstance = new ClassC();
                break;
            default:
                throw new ArgumentException("Invalid value");
        }
    }

    public void CallMethod()
    {
        _classInstance.DisplayMessage();
    }
}
