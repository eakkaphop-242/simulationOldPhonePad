namespace simulationOldPhonePad.Tests;

public class OldPhoneServiceTests
{
    public OldPhoneService oldPhoneService = new OldPhoneService();
    [Fact]
    public void posiviteCase()
    {
        string a = oldPhoneService.OldPhonePad("22#");
        Assert.Equal("B", a);
    }
}