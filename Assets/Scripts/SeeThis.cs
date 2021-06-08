using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeeThis : MonoBehaviour
{
    public GameObject dem;
    public varParser vP;
    // Start is called before the first frame update
    void Start()
    {
       
        dem= GameObject.Find("Ipass"); 
        vP=dem.GetComponent<varParser>();
       // isDiab=false;
       // toggleer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            SceneManager.LoadScene("MenuScene");
        }
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("SampleScene");
        }
       
    }
  
    public void SceneAndURLLoader()
    {
        
        SceneManager.LoadScene("SampleScene");
    }
}
