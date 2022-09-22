namespace MoneyExtension.Tests;

[TestClass]
public class MoneyTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal valor = 279.98M;
        int cents = valor.ToCent();

        Assert.AreEqual(27998, cents);
    }
}