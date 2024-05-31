using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCountViewer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private StageController stageController;
    private TextMeshProUGUI textCoinCount;

    private void Awake()
    {
        textCoinCount = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        textCoinCount.text = "Coins : " + stageController.CurrentConCount + "/" + stageController.MaxCoinCount;
    }
}
