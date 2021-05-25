using Interface;
using UnityEngine;
using UnityEngine.UI;

public class TextView : MonoBehaviour,ITextView
{
    [SerializeField] private Text countText;
    // Start is called before the first frame update
    private void Start()
    {
        countText.text = "count: 0";
    }

    public void SetText(string text)
    {
        countText.text = "count: " + text;
    }
}
