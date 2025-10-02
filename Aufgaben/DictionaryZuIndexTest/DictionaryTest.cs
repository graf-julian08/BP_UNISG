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
            expectedDict.SequenceEqual(invertedDict);
        }

        [TestMethod]
        public void TestDictionary2()
        {
            // Arrange
            Dictionary<string, List<string>> startDict = new Dictionary<string, List<string>>();

            startDict["Auto"] = new List<string> { "Räder", "Türe", "Rot" };
            startDict["Lastwagen"] = new List<string> { "Räder", "Türe", "Anhänger", "Gross" };
            startDict["Flugzeug"] = new List<string> { "Räder", "Türe", "Gross", "Flügel" };

            Dictionary<string, List<string>> expectedDict = new Dictionary<string, List<string>>();

            expectedDict["Räder"] = new List<string> { "Auto", "Lastwagen", "Flugzeug" };
            expectedDict["Türe"] = new List<string> { "Auto", "Lastwagen", "Flugzeug" };
            expectedDict["Rot"] = new List<string> { "Auto" };
            expectedDict["Anhänger"] = new List<string> { "Lastwagen" };
            expectedDict["Gross"] = new List<string> { "Lastwagen", "Flugzeug" };
            expectedDict["Flügel"] = new List<string> { "Flugzeug" };

            // Act
            TransformDict transformDict = new TransformDict();
            Dictionary<string, List<string>> invertedDict = transformDict.CreateIndex(startDict);

            // Assert
            expectedDict.SequenceEqual(invertedDict);
        }

        [TestMethod]
        public void TestDictionary3()
        {
            // Arrange
            Dictionary<string, List<string>> startDict = new Dictionary<string, List<string>>();

            startDict["Hund"] = new List<string> { "Bellen", "Pudel", "Schwanz" };
            startDict["Katze"] = new List<string> { "Schwanz", "Miau" };
            startDict["Maus"] = new List<string> { "Schwanz", "Klein", "Falle" };

            Dictionary<string, List<string>> expectedDict = new Dictionary<string, List<string>>();

            expectedDict["Bellen"] = new List<string> { "Hund" };
            expectedDict["Pudel"] = new List<string> { "Hund" };
            expectedDict["Schwanz"] = new List<string> { "Hund", "Katze", "Maus" };
            expectedDict["Miau"] = new List<string> { "Katze" };
            expectedDict["Klein"] = new List<string> { "Maus" };
            expectedDict["Falle"] = new List<string> { "Maus" };

            // Act
            TransformDict transformDict = new TransformDict();
            Dictionary<string, List<string>> invertedDict = transformDict.CreateIndex(startDict);

            // Assert
            expectedDict.SequenceEqual(invertedDict);
        }

        [TestMethod]
        public void TestDictionaryWrong1()
        {
            // Arrange
            Dictionary<string, List<string>> startDict = new Dictionary<string, List<string>>();

            startDict["Hund"] = new List<string> { "Bellen", "Pudel", "Schwanz" };
            startDict["Katze"] = new List<string> { "Schwanz", "Miau" };
            startDict["Maus"] = new List<string> { "Schwanz", "Klein", "Falle" };

            Dictionary<string, List<string>> expectedDict = new Dictionary<string, List<string>>();

            expectedDict["Räder"] = new List<string> { "Auto", "Lastwagen", "Flugzeug" };
            expectedDict["Türe"] = new List<string> { "Auto", "Lastwagen", "Flugzeug" };
            expectedDict["Rot"] = new List<string> { "Auto" };
            expectedDict["Anhänger"] = new List<string> { "Lastwagen" };
            expectedDict["Gross"] = new List<string> { "Lastwagen", "Flugzeug" };
            expectedDict["Flügel"] = new List<string> { "Flugzeug" };

            // Act
            TransformDict transformDict = new TransformDict();
            Dictionary<string, List<string>> invertedDict = transformDict.CreateIndex(startDict);

            // Assert
            Assert.AreNotEqual(expectedDict, invertedDict);
        }

        [TestMethod]
        public void TestDictionaryWrong2()
        {
            // Arrange
            Dictionary<string, List<string>> startDict = new Dictionary<string, List<string>>();

            startDict["Auto"] = new List<string> { "Räder", "Türe", "Rot" };
            startDict["Lastwagen"] = new List<string> { "Räder", "Türe", "Anhänger", "Gross" };
            startDict["Flugzeug"] = new List<string> { "Räder", "Türe", "Gross", "Flügel" };

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
            Assert.AreNotEqual(expectedDict, invertedDict);
        }

        [TestMethod]
        public void TestDictionaryWrong3()
        {
            // Arrange
            Dictionary<string, List<string>> startDict = new Dictionary<string, List<string>>();

            startDict["Blume"] = new List<string> { "Blatt", "Stiel", "Blüte", "Grün" };
            startDict["Baum"] = new List<string> { "Stamm", "Ast", "Blüte", "Grün", "Blatt" };
            startDict["Pilz"] = new List<string> { "Hut", "Farbe", "Stiel" };

            Dictionary<string, List<string>> expectedDict = new Dictionary<string, List<string>>();

            expectedDict["Bellen"] = new List<string> { "Hund" };
            expectedDict["Pudel"] = new List<string> { "Hund" };
            expectedDict["Schwanz"] = new List<string> { "Hund", "Katze", "Maus" };
            expectedDict["Miau"] = new List<string> { "Katze" };
            expectedDict["Klein"] = new List<string> { "Maus" };
            expectedDict["Falle"] = new List<string> { "Maus" };

            // Act
            TransformDict transformDict = new TransformDict();
            Dictionary<string, List<string>> invertedDict = transformDict.CreateIndex(startDict);

            // Assert
            Assert.AreNotEqual(expectedDict, invertedDict);
        }
    }
}