using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caneSound : MonoBehaviour
{
    public AudioClip ashcan;
    public AudioClip chair;
    public AudioClip ball;
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("ashcan"))   //当条件触发
        {
            //source.PlayOneShot(water, 1F);
            source.PlayOneShot(ashcan);
            
            Debug.Log("sound....."); //播放声音
        }
        if (other.CompareTag("chair"))   //当条件触发
        {
            //source.PlayOneShot(water, 1F);
            source.PlayOneShot(chair);

            Debug.Log("sound2....."); //播放声音
        }
        if (other.CompareTag("ball"))   //当条件触发
        {
            //source.PlayOneShot(water, 1F);
            source.PlayOneShot(ball);

            Debug.Log("sound2....."); //播放声音
        }

    }
    private void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("ashcan"))   //当条件触发
        {
            //source.PlayOneShot(water, 1F);
            if (Time.frameCount % 10 == 0)            {
                source.PlayOneShot(ashcan);
            }

            Debug.Log("sound.....123"); //播放声音
        }
        if (other.CompareTag("chair"))   //当条件触发
        {
            //source.PlayOneShot(water, 1F);
            if (Time.frameCount % 10 == 0)            {
                source.PlayOneShot(chair);

              
            }//播放声音
        }
        if (other.CompareTag("ball"))   //当条件触发
        {
            //source.PlayOneShot(water, 1F);
            if (Time.frameCount % 10 == 0)            {
                source.PlayOneShot(ball);

                Debug.Log("sound2.....123");
            }//播放声音
        }

    }
}

/*public class Audio_Opendoor : MonoBehaviour
{

    public AudioClip OpenDoorSound;  //指定需要播放的音效
    private AudioSource source;   //必须定义AudioSource才能调用AudioClip


    void Start()
    {
        source = GetComponent<AudioSource>();  //将this Object 上面的Component赋值给定义的AudioSource
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.Process == "MissionAception")   //当条件触发
        {
            source.PlayOneShot(OpenDoorSound, 1F);   //播放声音
        }
    }
}


————————————————
版权声明：本文为CSDN博主「jennyhigh」的原创文章，遵循 CC 4.0 BY-SA 版权协议，转载请附上原文出处链接及本声明。
原文链接：https://blog.csdn.net/jennyhigh/article/details/86687328*/