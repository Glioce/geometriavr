using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManger : MonoBehaviour
{
    #region Static Instance
    private static AudioManger instance;
    public static AudioManger Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<AudioManger>();
                if (instance == null)
                {
                    instance = new GameObject("AudioManagerInstance", typeof(AudioManger)).GetComponent<AudioManger>();
                }
            }
            return instance;
        }
        private set
        {
            instance = value;
        }
    }
    #endregion

    #region Fields
    private AudioSource music;
    private AudioSource sfx;
    #endregion

    private void Awake()
    {
        //esta instancia no se debe destruir
        DontDestroyOnLoad(this.gameObject);

        //crear fuentes de audio y guardar las referencias
        music = this.gameObject.AddComponent<AudioSource>();
        sfx = this.gameObject.AddComponent<AudioSource>();
    }

    public void PlayMusic(AudioClip musicClip, bool loop = true, float vol = 0.5f)
    {
        music.clip = musicClip;
        music.loop = loop;
        music.volume = vol;
        music.Play();
    }
}
