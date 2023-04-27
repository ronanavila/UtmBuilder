using UtmBuilder.Core.ValueObjects;


namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
[TestCategory("Utm Tests")]
public class UtmTests
{
    private const string FinalUrl = "https://balta.io/" + "?utm_source=src" + "&utm_medium=med" + "&utm_campaign=nme" +
                                    "&utm_id=id" + "&utm_term=ter" + "&utm_content=ctn";

    private readonly Url URL = new("https://balta.io/");

    private readonly Campaign Campaign = new("src", "med", "nme", "id", "ter", "ctn");

    [TestMethod]
    public void ShouldReutnUrlFromUtm()
    {
        var utm = new Utm(URL, Campaign);

        Assert.AreEqual(FinalUrl, utm.ToString());
        Assert.AreEqual(FinalUrl, (string)utm);

    }

    [TestMethod]
    [TestCategory("Utm Tests")]
    public void ShouldReutnUtmFromUrl()
    {
        Utm umtFromUrlString = FinalUrl;

        Assert.AreEqual("https://balta.io/", umtFromUrlString.Url.Address);
        Assert.AreEqual("src", Campaign.Source);
        Assert.AreEqual("med", Campaign.Medium);
        Assert.AreEqual("nme", Campaign.Name);
        Assert.AreEqual("id", Campaign.Id);
        Assert.AreEqual("ter", Campaign.Term);
        Assert.AreEqual("ctn", Campaign.Content);

    }
}

