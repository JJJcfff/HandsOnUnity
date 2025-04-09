    
    using TMPro;
    using UnityEngine;

    public class WavesUI : MonoBehaviour
    {
        TMP_Text text;

        void Start()
        {
            text = GetComponent<TMP_Text>();
            WaveManager.instance.onChanged.AddListener(RefreshText);
        }

        void RefreshText()
        {
            text.text = "Remaining Waves: " + WaveManager.instance.waves.Count;
        }
    }


