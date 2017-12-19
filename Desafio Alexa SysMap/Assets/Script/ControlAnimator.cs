using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ControlAnimator : MonoBehaviour {

    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    public AudioClip clip4;
    public AudioClip clip5;
    public AudioClip clip6;
    public AudioClip clip7;
    public AudioClip clip8;
    public AudioClip clip9;
    public AudioClip clip10;

    // Use this for initialization
    void Start() {
        //GetComponent<Animator>().StartPlayback();
        //GetComponent<Animator>().StopPlayback();

        GetComponentInChildren<AudioSource>().mute = false;
        GetComponentInChildren<AudioSource>().loop = false;
        GetComponentInChildren<AudioSource>().playOnAwake = true;

        GetComponentInChildren<AudioSource>().playOnAwake = true;

        StartCoroutine(WaitAndTalk());

    }

    // Update is called once per frame
    void Update() {
        //Debug.Log("nome do objeto: " + GetComponent<Animator>().name.ToString());

    }


    IEnumerator WaitAndTalk(){

            for (int i = 1; i < 11; i++)
            {
            TalkAlexa(i);
            yield return new WaitForSeconds(10);
        }

    }

    void TalkAlexa(int intClip)
    {
        if (intClip == 1)
            GetComponentInChildren<AudioSource>().clip = clip1;

        if (intClip == 2)
            GetComponentInChildren<AudioSource>().clip = clip2;

        if (intClip == 3)
            GetComponentInChildren<AudioSource>().clip = clip3;

        if (intClip == 4)
            GetComponentInChildren<AudioSource>().clip = clip4;

        if (intClip == 5)
            GetComponentInChildren<AudioSource>().clip = clip5;

        if (intClip == 6)
            GetComponentInChildren<AudioSource>().clip = clip6;

        if (intClip == 7)
            GetComponentInChildren<AudioSource>().clip = clip7;

        if (intClip == 8)
            GetComponentInChildren<AudioSource>().clip = clip8;

        if (intClip == 9)
            GetComponentInChildren<AudioSource>().clip = clip9;

        if (intClip == 10)
            GetComponentInChildren<AudioSource>().clip = clip10;

        GetComponentInChildren<AudioSource>().Play();
    }
}
