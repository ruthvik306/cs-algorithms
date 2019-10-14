using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class colourchanger : MonoBehaviour
{
    public Material watching;
    public Material notwatching;
    public float timer = 0f;

    public Transform radialtimer;
    public bool var = false;
    public bool var1 = false;

    public string word;
	// Use this for initialization
	void Start ()
    {
        GetComponent<Renderer>().material = notwatching;
        radialtimer.GetComponent<Image>().fillAmount = timer;
        
	}
    public void Update()
    {   
        if(var)
        timer = timer + Time.deltaTime;
        radialtimer.GetComponent<Image>().fillAmount = timer;
    }
    public void reseter()
    {
        timer = 0f;     
    }
    public void looking()
    {
        StartCoroutine(lookStart());
        StartCoroutine(ChangeScene());
        //timer = 0f;
        //timer = timer + Time.deltaTime;
        GetComponent<Renderer>().material = watching;
        radialtimer.GetComponent<Image>().fillAmount = timer;
       
    }
    public void notlooking()
    {
        reseter();
        var = false;
        StopAllCoroutines();
        
        radialtimer.GetComponent<Image>().fillAmount = 0.0f;
        GetComponent<Renderer>().material = notwatching;
    }
    IEnumerator lookStart()
    {
        var = true;
        yield return new WaitForSeconds(3f);
        if(var)
        StartCoroutine(ChangeScene());
        var = false;
    }
    IEnumerator ChangeScene()
    {       
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("1");
    }
}
 