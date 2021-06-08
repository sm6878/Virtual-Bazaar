using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class varParser : MonoBehaviour
{
    // Start is called before the first frame update
    public Text name;
    public Text cal;
    public string s1,s2;
    public bool isdiaa=false;
    void Awake() 
    {   
    DontDestroyOnLoad(transform.gameObject);
        }
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        s1=name.text;
        s2=cal.text;
    }
    public void flipper()
    {
        isdiaa=!isdiaa;
    }
}
