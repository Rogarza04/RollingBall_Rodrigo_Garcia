using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSourceSfx2 ;

    [SerializeField] private AudioSource audioSourceSfx ;

    public void ReproducirSonido(AudioClip clip)
    {
        audioSourceSfx.PlayOneShot(clip);
        audioSourceSfx2.PlayOneShot(clip);
    }
}
