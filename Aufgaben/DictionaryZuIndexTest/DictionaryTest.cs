using DictionaryZuIndex;

namespace DictionaryZuIndexTest
{
    [TestClass]
    public sealed class DictionaryTest
    {
        [TestMethod]
        public void TestDictionary1()
        {
            // Arrange
            Dictionary<string, List<string>> startDict = new Dictionary<string, List<string>>();

            startDict["Blume"] = new List<string> { "Blatt", "Stiel", "Blüte", "Grün" };
            startDict["Baum"] = new List<string> { "Stamm", "Ast", "Blüte", "Grün", "Blatt" };
            startDict["Pilz"] = new List<string> { "Hut", "Farbe", "Stiel" };

            Dictionary<string, List<string>> expectedDict = new Dictionary<string, List<string>>();

            expectedDict["Blatt"] = new List<string> { "Blume", "Baum" };
            expectedDict["Stiel"] = new List<string> { "Blume", "Pilz" };
            expectedDict["Blüte"] = new List<string> { "Blume", "Baum" };
            expectedDict["Grün"] = new List<string> { "Blume", "Baum" };
            expectedDict["Stamm"] = new List<string> { "Baum" };
            expectedDict["Ast"] = new List<string> { "Baum" };
            expectedDict["Hut"] = new List<string> { "Pilz" };
            expectedDict["Farbe"] = new List<string> { "Pilz" };

            // Act
            TransformDict transformDict = new TransformDict();
            Dictionary<string, List<string>> invertedDict = transformDict.CreateIndex(startDict);

            // Assert
            CollectionAssert.AreEqual(expectedDict, invertedDict);
        }
    }
}
