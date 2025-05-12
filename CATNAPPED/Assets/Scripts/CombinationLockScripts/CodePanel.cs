using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CodePanel : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI codeText;
    PuzzleProgressionTracker combinationLock;
    FlashlightSpawn flashlightChecker;
    string codeTextValue = "";

    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == "1711") 
        {
            combinationLock.combinationLockComplete = true;
            flashlightChecker.UpdateSpawn();
            BlowUpIfComplete();
        }

        if (codeTextValue.Length >= 4) 
        {
            codeTextValue = "";
        }
    }

    public void AddDigit(string digit) 
    {
        codeTextValue += digit;
    }

    public void BlowUpIfComplete() 
    {
        var toolbox = GameObject.Find("ToolBoxLock");
        toolbox.IsDestroyed();
    }
}
