using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSound : MonoBehaviour
{
    private AudioSource sound;
    public AudioClip clip;

    private double t = 0;

    void Start()
    {

    }
    private void FixedUpdate()
    {
        t += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            sound = gameObject.AddComponent<AudioSource>();
            sound.clip = clip;
            if (!sound.isPlaying)
            {
                sound.Play();
            }
        }
    }
    private void OnTriggerStay(Collider other)
    { 
        if (other.gameObject.tag == "Player")  //当条件触发
        {
            //source.PlayOneShot(water, 1F);
            if (t > 0.4)            {
                sound.Play();
               // Debug.Log("sound2.....");
                t = 0;
            }//播放声音
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(sound,1);
        }
    }
}

