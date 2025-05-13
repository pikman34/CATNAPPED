using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CodePanel : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI codeText;
    GameObject toolBoxCombination;
    PuzzleProgressionTracker combinationLock;
    FlashlightSpawn flashlightChecker;
    string codeTextValue = "";

    void Awake()
    {
        combinationLock = GameObject.Find("ProgressionTracker").GetComponent<PuzzleProgressionTracker>();
        flashlightChecker = GameObject.Find("FlashlightSpawner").GetComponent<FlashlightSpawn>();
        toolBoxCombination = GameObject.Find("ToolBoxLock");

    }

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
        Destroy(toolBoxCombination);
    }
}
