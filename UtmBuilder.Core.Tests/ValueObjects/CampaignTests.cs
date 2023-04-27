using System.Text.RegularExpressions;
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class CampaignTests
{

    [TestMethod]
    [TestCategory("Campaign Tests")]
    [DataRow("","","", true)]
    [DataRow("source", "", "", true)]
    [DataRow("", "medium", "", true)]
    [DataRow("", "", "name", true)]
    [DataRow("source", "medium", "", true)]
    [DataRow("source", "", "name", true)]
    [DataRow("", "medium", "name", true)]   
    [DataRow("source","medium","name", false)]
    public void TestCampaign(string source, string medium, string name,bool expectException)
    {
        if (expectException)
        {
            try
            {
                new Campaign(source,medium,name);
                Assert.Fail();
            }
            catch (InvalidCampignException)
            {
                Assert.IsTrue(true);
            }
        }
        else
        {
            new Campaign(source, medium, name);
            Assert.IsTrue(true);
        }
    }
}

