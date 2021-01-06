using UnityEngine;
using UnityEngine.UI;

public class GlobalEuro : MonoBehaviour
{
    public static ulong EuroCount { get; set; }
    public static float Multiplier { get; set; } = 0.0F;

    public GameObject EuroDisplay;

    void Update()
    {
        EuroDisplay.GetComponent<Text>().text = "Euro: " + EuroCount;
    }
}
