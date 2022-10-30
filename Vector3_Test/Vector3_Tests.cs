using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest_Example;


[TestClass]
public class Vector3_Test
{
    [TestMethod]
    public void TestToString()
    {
        Vector3 v = new Vector3 { X = 1, Y = 2, Z = 3 };
        string vstr = v.ToString();
        Assert.AreEqual<string>("<1, 2, 3>", vstr);
    }

    [DataTestMethod]
    [DataRow(1, 2, 3, "<1, 2, 3>")]
    [DataRow(4, 4, 4, "<4, 4, 4>")]
    [DataRow(1, 2, 3, "<1, 2, 3>")]
    [DataRow(1.1, 2.2, 3.3, "<1.1, 2.2, 3.3>")]
    [DataRow(1.1, 2, 3.3, "<1.1, 2, 3.3>")]
    [DataRow(0, 2, 3.3, "<0, 2, 3.3>")]
    [DataRow(0, 2, 3.345, "<0, 2, 3.345>")]
    public void TestToString_Multiple(double x, double y, double z, string expected)
    {
        Vector3 v = new Vector3 { X = x, Y = y, Z = z };
        string vstr = v.ToString();
        Assert.AreEqual<string>(expected, vstr);
    }

    [DataTestMethod]
    [DataRow(1, 1, 1, 2, 2, 2, 3, 3, 3)]
    [DataRow(1, 2, 3, 1, 2, 3, 2, 4, 6)]
    [DataRow(1.1, 2.2, 3.3, 1.1, 2.2, 3.3, 2.2, 4.4, 6.6)]
    public void TestAdd(double x1, double y1, double z1,
                        double x2, double y2, double z2,
                        double ex, double ey, double ez)
    {
        Vector3 v1 = new Vector3 { X = x1, Y = y1, Z = z1};
        Vector3 v2 = new Vector3 { X = x2, Y = y2, Z = z2};
        Vector3 res = v1.Add(v2);

        Vector3 expected = new Vector3 { X = ex, Y = ey, Z = ez };

        Assert.AreEqual<Vector3>(expected, res);
    }

    [TestMethod]
    public void TestEqualsNull()
    {
        Vector3 v = new Vector3 { X = 1, Y = 1, Z = 1};

        Assert.IsFalse(v == null);
    }

    [TestMethod]
    public void TestEquals()
    {
        Vector3 v1 = new Vector3 { X = 1, Y = 2, Z = 3};
        Vector3 v2 = new Vector3 { X = 1, Y = 2, Z = 3};

        Assert.AreEqual(v1, v2);
    }

    [TestMethod]
    public void TestNotEquals()
    {
        Vector3 v1 = new Vector3 { X = 1, Y = 2, Z = 3};
        Vector3 v2 = new Vector3 { X = 2, Y = 3, Z = 4};

        Assert.AreNotEqual(v1, v2);
    }
}