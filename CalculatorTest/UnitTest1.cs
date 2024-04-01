using Microsoft.VisualStudio.TestPlatform.TestHost;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void Test_Addition()
    {
        string[] input = { "+", "10", "5" };
        string expectedOutput = "The result of '10 + 5' is: 15";

        string actualOutput = ExecuteProgramWithInput(input);

        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [TestMethod]
    public void Test_Subtraction()
    {
        string[] input = { "-", "10", "5" };
        string expectedOutput = "The result of '10 - 5' is: 5";

        string actualOutput = ExecuteProgramWithInput(input);

        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [TestMethod]
    public void Test_Division()
    {
        string[] input = { "/", "10", "2" };
        string expectedOutput = "The result of '10 / 2' is: 5";

        string actualOutput = ExecuteProgramWithInput(input);

        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [TestMethod]
    public void Test_Multiplication()
    {
        string[] input = { "*", "10", "5" };
        string expectedOutput = "The result of '10 * 5' is: 50";

        string actualOutput = ExecuteProgramWithInput(input);

        Assert.AreEqual(expectedOutput, actualOutput);
    }

    private string ExecuteProgramWithInput(string[] input)
    {
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            Console.SetIn(new StringReader(string.Join("\n", input) + "\n"));
            Calculator.Main(new string[0]);
            string output = sw.ToString().Trim();
            string finalResult = output.Substring(output.LastIndexOf("The result of"));
            return finalResult;
        }
    }
}
