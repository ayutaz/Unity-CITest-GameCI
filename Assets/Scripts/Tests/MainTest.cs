using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;
using UnityUITest;

public class MainTest : UITest
{
    // A Test behaves as an ordinary method
    [Test]
    public void UITestSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator UITestWithEnumeratorPasses()
    {
        yield return LoadScene("Main");
        yield return Press("Button");
    }
}
