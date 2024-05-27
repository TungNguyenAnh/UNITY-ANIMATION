using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideManager : MonoBehaviour
{
    [SerializeField]
    private Slider mySlider;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(mySlider.minValue);
        Debug.Log(mySlider.maxValue);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(mySlider.value);
    }
    public void OnSliderValueChanged(float value)
    {
        Debug.Log("Da co su thay doi");
    }
}
