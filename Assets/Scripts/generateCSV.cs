using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;
using System;
using UnityEngine.UI;

public class generateCSV : MonoBehaviour
{
    
    private List<string[]> rowData = new List<string[]>();
    
    private string s;
    
      public Text SugarVal;
      public Text CarbsVal;
      public Text PriceVal;
        public ObjectSelector obj;
    public GameObject gameObject;

     public GameObject cantPrint;
       // public Text prodList;
    bool swi=false;

    // Use this for initialization
    void Start()
    {
        s=obj.naam;
    }
    void Update()
    {
        
        if (Input.GetKeyDown("p"))
        {
            if(obj.okji!=1)
            {swi=!swi;
              // gameObject.SetActive(swi);
            Save();}
            else
            {
                    
            }
            Debug.Log(swi);
            cantPrint.SetActive(!swi);
        }
    }
    
    void Save(){

        // Creating First row of titles manually..
        string[] rowDataTemp = new string[4];
        rowDataTemp[0] = "Sugar";
        rowDataTemp[1] = "Carbs";
        rowDataTemp[2] = "Calories";
        rowDataTemp[3] = "Name";
       // rowDataTemp[3] = "Poduct List";
        rowData.Add(rowDataTemp);

        // You can add up the values in as many cells as you want.
        
            rowDataTemp = new string[4];
            rowDataTemp[0] = SugarVal.text; //
            rowDataTemp[1] = CarbsVal.text; // 
            rowDataTemp[2] = PriceVal.text; // 
            rowDataTemp[3] = s;
            rowData.Add(rowDataTemp);
        

        string[][] output = new string[rowData.Count][];

        for(int i = 0; i < output.Length; i++){
            output[i] = rowData[i];
        }

        int     length         = output.GetLength(0);
        string     delimiter     = ",";

        StringBuilder sb = new StringBuilder();
        
        for (int index = 0; index < length; index++)
            sb.AppendLine(string.Join(delimiter, output[index]));
        
        
        string filePath = getPath();

        StreamWriter outStream = System.IO.File.CreateText(filePath);
        outStream.WriteLine(sb);
        outStream.Close();

        gameObject.SetActive(swi);
        Debug.Log("printed");
    }

    // Following method is used to retrive the relative path as device platform
    private string getPath(){

        ///Write youer username here

        #if UNITY_EDITOR
        return "E:/"+"Saved_data.csv";
        #else
        return "E:/"+"Saved_data.csv";
        #endif

      
    }
}
