using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
    // Start is called before the first frame update
    private int maxCoinCount;
    private int currentCoinCount;
        
    public int MaxCoinCount => maxCoinCount;
    public int CurrentConCount => currentCoinCount;


    private void Awake()
    {
        maxCoinCount = GameObject.FindGameObjectWithTag("Coin").layer;
        currentCoinCount = maxCoinCount;
    }
}
