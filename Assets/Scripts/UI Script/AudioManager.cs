using UnityEngine;
using UnityEngine.Audio;
public class Audio : MonoBehaviour
{

    [SerializeField] AudioClip slashSound;
    [SerializeField] AudioSource defaultSource;
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] AudioMixerSnapshot cutsceneShot;

    private void Start()
    {
        cutsceneShot.TransitionTo(5f);
    }

    public void PlayJump()
    {
        defaultSource.PlayOneShot(slashSound);
    }
    
    public void ChangeVolume(float volume)
    {
        audioMixer.SetFloat("MasterVolume", volume);
    }
}
