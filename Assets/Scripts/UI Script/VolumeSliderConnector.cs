using UnityEngine;
using UnityEngine.UI;

public class VolumeSliderConnector : MonoBehaviour
{
    void Start()
    {
        Slider slider = GetComponent<Slider>();
        
        if (slider != null && Audio.Instance != null)
        {
            slider.onValueChanged.AddListener(Audio.Instance.SetVolume);
        }
    }
}