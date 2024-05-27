using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private float diamond = 0;
    private int roundNumber = 0;
    private int coinNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetDiamond(float diamond)
    {
        this.diamond += diamond;
    }
    public void SetRoundNumber(int roundNumber)
    {
        this.roundNumber += roundNumber;
    }

    public void SetCoin(int coinNumber)
    {
        this.coinNumber += coinNumber;
    }

    public int GetCoin()
    {
        return coinNumber;
    }
    public float GetDiamond()
    {
        return diamond;
    }
}
