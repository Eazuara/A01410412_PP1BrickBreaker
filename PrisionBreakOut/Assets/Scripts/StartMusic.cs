using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour {
    public AudioSource fuente;
    public AudioClip clip;
    StartMusic instance;
	// Use this for initialization
	

    public void Reproducir()
    {
        fuente.Play();
        DontDestroyOnLoad(clip);

    }
    void Awake()
    {
        fuente.clip = clip;
        //  If the instance is not null, then we destroy this gameObject so we
        //  do not have duplicates
        if (instance != null)
        {
            Destroy(gameObject);
        }
        //  However, if the instance is indeed null, then we asociate it to this
        //  gameObject and we ask Unity to not destroy it on every load.
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

}
