using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextManager : MonoBehaviour
{
    [SerializeField] private Text inputText;
    [SerializeField] private TextMeshProUGUI finalText;

    public void LoadText()
    {
        finalText.text = inputText.text;
    }
}
