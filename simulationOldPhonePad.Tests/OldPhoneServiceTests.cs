namespace simulationOldPhonePad.Tests;

public class OldPhoneServiceTests
{
    public OldPhoneService oldPhoneService = new OldPhoneService();

    public static IEnumerable<object[]> TestData_PositiveCase()
    {
        yield return new object[] { "222 2 22", "CAB" };
        yield return new object[] { "33#", "E" };
        yield return new object[] { "227*#", "B" };
        yield return new object[] { "4433555 555666#", "HELLO" };
        yield return new object[] { "6999#", "MY" };
        yield return new object[] { "662633#", "NAME" };
        yield return new object[] { "22 2 7777#", "BAS" };
    }

    public static IEnumerable<object[]> TestData_NegativeCase()
    {
        yield return new object[] { "8 88777444666*664#", "??????" };
        yield return new object[] { "123#", "???" };
        yield return new object[] { "22 2 333391*##", "????" };
        yield return new object[] { "6*6*77* *22 111#", "???" };
    }

    [Theory]
    [MemberData(nameof(TestData_PositiveCase))]
    [MemberData(nameof(TestData_NegativeCase))]
    public void PosiviteCase(string userInput, string expected)
    {
        string textMessage = oldPhoneService.OldPhonePad(userInput);
        Assert.Equal(expected,textMessage);
    }
}