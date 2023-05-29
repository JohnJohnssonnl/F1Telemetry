using F1Telemetry;

public class TestProgram
{
    Application ApplicationToRun;

    public static void Main()
    {
        TestProgram TestProgram = new TestProgram();
        TestProgram.ApplicationToRun = new F1Telemetry.Application(20777, TestProgram);
        //Keep the program alive to test until a button is pressed
        Console.ReadLine();
    }

    public void NewMessageReceived()
    {
        Console.WriteLine("Message processed");
    }
}