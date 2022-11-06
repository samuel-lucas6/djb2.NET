using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using djb2DotNet;

namespace djb2DotNetTests;

[TestClass]
public class djb2Tests
{
    // https://theartincode.stanis.me/008-djb2/
    [TestMethod]
    [DataRow("Hello", (ulong)210676686969)]
    [DataRow("Hello!", (ulong)6952330670010)]
    public void Test(string message, ulong hash)
    {
        Span<byte> m = Encoding.UTF8.GetBytes(message);
        ulong h = djb2.ComputeHash(m);
        Assert.AreEqual(hash, h);
    }
}