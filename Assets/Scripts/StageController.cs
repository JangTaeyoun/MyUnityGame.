using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private string nextSceneName;
    [SerializeField]
    private GameObject panelStageClear;
    private int maxCoinCount;
    private int currentCoinCount;
    private bool getAllCoins = false;

    public int MaxCoinCount => maxCoinCount;
    public int CurrentConCount => currentCoinCount;
    

    private void Awake()
    {
        Time.timeScale = 1.0f;
        panelStageClear.SetActive(false);

        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");
        maxCoinCount = coins.Length;
        currentCoinCount = maxCoinCount;
    }

    private void Update()
    {
        if ( getAllCoins == true )
        {
            if ( Input.GetKeyDown(KeyCode.Return) )
                {
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }
    public void GetCoin()
    {
        currentCoinCount--;

        if(currentCoinCount == 0 )
        {
            getAllCoins = true;
            Time.timeScale = 0.0f;
            panelStageClear.SetActive(true);
        }
    }
}
