using UnityEngine;
using UnityEngine.Audio;


public class MixerController : MonoBehaviour
{
    [SerializeField] private AudioMixer auMixer;
    
    public void SetVolume(float sliderValue)
    {
        // auMixer.SetFloat("MainVolume",Mathf.Log10(sliderValue * 20));
        auMixer.SetFloat("MainVolume",sliderValue);

    }
}