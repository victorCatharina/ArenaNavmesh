using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{


    [SerializeField] private AudioMixer mixer;
    [SerializeField] private Slider volumeSlider;

    [SerializeField] private AudioSource audioSourceMusicaDeFundo; 
    [SerializeField] private AudioClip[] musicasDeFundo;
    // Start is called before the first frame update
    void Start()
    {
        AudioClip audioClip = musicasDeFundo[0];
        audioSourceMusicaDeFundo.clip = audioClip;
        audioSourceMusicaDeFundo.Play();
    }


    public void SetMuiscVolume(Slider slider)
    {
        switch (slider.value)
        {
            case 0:
                mixer.SetFloat("music", -88);
                break;
            case 1:
                mixer.SetFloat("music", -40);
                break;
            case 2:
                mixer.SetFloat("music", -20);
                break;
            case 3:
                mixer.SetFloat("music", -10);
                break;
            case 4:
                mixer.SetFloat("music", 0);
                break;
            case 5:
                mixer.SetFloat("music", 10  );
                break;                                                                                
        }

    }

}
