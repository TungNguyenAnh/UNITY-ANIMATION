using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textCoin;
    [SerializeField] private TextMeshProUGUI textDiamond;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        updateCoin();
        updateDiamond();
    }
    void updateCoin()
    {
        int coin = GameManager.Instance.GetCoin();
        textCoin.text = coin.ToString();
    }

    void updateDiamond()
    {
        float Diamond = GameManager.Instance.GetDiamond();
        textDiamond.text = Diamond.ToString();
    }
    // IEnumerator UpdateValue()
    // {
    //     while (true)
    //     {
    //         yield return new WaitForSeconds(0.5f);
    //         updateCoin();
    //         updateDiamond();
    //     }
    // }
}
