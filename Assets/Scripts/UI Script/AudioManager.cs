using UnityEngine;
using UnityEngine.Audio;
public class Audio : MonoBehaviour
{


    [SerializeField] AudioSource defaultSource;
    [SerializeField] AudioMixer audioMixer;


    private void Start()
    {
        
    }


    public void ChangeVolume(float volume)
    {
        defaultSource.volume = volume;
    }
}
