using UnityEngine;

namespace Assets.Scripts
{
    public class GlobalEuroClick : MonoBehaviour
    {
        public GameObject textBox;
        public void EuroOnClicked()
        {
            GlobalEuro.EuroCount += (ulong)(GlobalEuro.EuroCount * GlobalEuro.Multiplier + 1);
            textBox.SetActive(true);
        }
    }
}
