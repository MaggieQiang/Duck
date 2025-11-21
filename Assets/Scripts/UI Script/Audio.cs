using UnityEngine;
using UnityEngine.Audio;
public class Audio : MonoBehaviour
{

    public static Audio Instance { get; private set; }
    [SerializeField] AudioSource defaultSource;
    [SerializeField] private AudioSource sfxSource;
    [SerializeField] private AudioMixer audioMixer;
    public AudioClip background;
    public AudioClip shooting;
    public AudioClip drowning;
    [SerializeField] private string parameterName = "BGMVolume";

    public void SetVolume(float value)
    {
        float dB = value > 0.0001f ? Mathf.Log10(value) * 20 : -80f;
        audioMixer.SetFloat(parameterName, dB);
    }


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        if (defaultSource != null && background != null)
        {
            defaultSource.clip = background;
            defaultSource.loop = true;
            defaultSource.Play();
        }
    }
    
    public void ShootSound()
    {
        if (sfxSource != null && shooting != null)
        {
            sfxSource.PlayOneShot(shooting);
        }
    }


    public void DrownSound()
    {
        if (sfxSource != null && drowning != null)
        {
            sfxSource.PlayOneShot(drowning);
        }
    }

    public void ChangeVolume(float volume)
    {
        defaultSource.volume = volume;
    }
}
