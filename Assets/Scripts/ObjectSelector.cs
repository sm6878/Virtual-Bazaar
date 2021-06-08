using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ObjectSelector : MonoBehaviour
{
    // Start is called before the first frame update
   public bool selected;
   public string[] ProductNames;

    public bool weFailin=false;
   public int[] priceArray;  
    public Text warning;
   public int[] CarbsArray;

   public int[] SugarArray;  
   public Text productNameTextBox;
   public Text productIncart;
   public Text sugarTotal;
   public Text carbsTotal;

   private int sugarCalc=0;
   private int carbsCalc=0;
  // private int calorieCalc=0;
   private float ratioCalc=0f; 
   public Text cartTotal; 
private int selectedObj=-1;
   private int price=0;
   public GameObject[] nutritionImages;
   public GameObject uiPannel;
    public GameObject carbsWarning;
    public GameObject calWarning;
    public GameObject dem;
    public string naam;
    public varParser vP;
public GameObject toggleer;
public GameObject calDaily;
public int okji=0;
     public GameObject cbb;

     private int dCal;
  public bool isDiab;
    void Start()
    {
       // calDaily=GameObject.Find("calDal");
          dem= GameObject.Find("Ipass"); 
        vP=dem.GetComponent<varParser>();
        naam=vP.s1;
        isDiab =vP.isdiaa;
    cartTotal.text=" " ;
     toggleer.SetActive(isDiab);
        dCal=int.Parse(vP.s2);

    uiPannel.SetActive(false);
    selected=false;
    productNameTextBox.text="";
    sugarTotal.text="";
    carbsTotal.text="";
    }

    // Update is called once per frame
    void Update()
    {
          if (Input.GetKeyDown("y"))
        {
            isDiab=!isDiab;
             toggleer.SetActive(isDiab);
        }
        if(isDiab)
        {
           
            if(carbsCalc>250)
           { weFailin=true;
            okji=1;
           cbb.SetActive(true);
           carbsWarning.SetActive(true);}
            if(price>2000)
           { weFailin=true;
             cbb.SetActive(true);
              okji=1;
            calWarning.SetActive(true);
           }

        }

        if(price>dCal)
        {
            calDaily.SetActive(true);
        }

        cartTotal.text=" "+price.ToString() ;
        sugarTotal.text=sugarCalc.ToString();
        carbsTotal.text=carbsCalc.ToString();
        if(Input.GetMouseButtonDown(0))
        {  if(selectedObj==-1)
            {}
            if(selectedObj==0)
            {
            productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
           
            }
            if(selectedObj==1)
            {
           productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
           
            }
            if(selectedObj==2)
            {
           productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
           
            }
            if(selectedObj==3)
            {
           productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
           
            }
            if(selectedObj==4)
            {
            productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
           
            }
            if(selectedObj==5)
            {
            productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
           
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
            }
            if(selectedObj==6)
            {
            productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
           
            }
            if(selectedObj==7)
            {
            productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
           
            }
            if(selectedObj==8)
            {
            productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
           
            }
            if(selectedObj==9)
            {
            productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
           
            }
            if(selectedObj==10)
            {
            productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
           
            }
            if(selectedObj==11)
            {
            productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
           
            }
            if(selectedObj==12)
            {
            productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
           
            }
            if(selectedObj==13)
            {
            productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
           
            }
            if(selectedObj==14)
            {
            productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
           
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
            }
            if(selectedObj==15)
            {
            productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
           
            }
            if(selectedObj==16)
            {
            productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
           
            }
            if(selectedObj==17)
            {
            productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
           
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
            }
            if(selectedObj==18)
            {
            productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
           
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
            }
            if(selectedObj==19)
            {
            productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
           
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
            }

            if(selectedObj==20)
            {
            productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
           
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
            }
            if(selectedObj==21)
            {
            productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
           
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
            }
            if(selectedObj==22)
            {
            productIncart.text+=ProductNames[selectedObj]+"\n";
            price+=priceArray[selectedObj];
           
            sugarCalc+=SugarArray[selectedObj];
            carbsCalc+=CarbsArray[selectedObj];
            }

            
          //  Debug.Log("Mouse");
        }
    }
	void OnTriggerEnter(Collider col) 
    {

		
             int k;
         //   Debug.Log(col.gameObject.name[7]);
           k= int.Parse(col.gameObject.name)-1;
           Debug.Log(k);
        if(k>=0 && k<=25)   
       { nutritionImages[k].SetActive(true);
        uiPannel.SetActive(true);
        selected=true;
        if(CarbsArray[k]!=0)
        ratioCalc=SugarArray[k]/CarbsArray[k];
        string warn="";
        if(ratioCalc>=0.05)
        { 
            warn="Warning Sugar is high";

        }
        warning.text=warn;
        productNameTextBox.text+=ProductNames[k];
        productNameTextBox.text+=" "+"\n"+"Calories: "+priceArray[k].ToString()+"\n"+"Sugar: "+SugarArray[k]+"\nCarbs: "+CarbsArray[k];
        selectedObj=k; 
       }
    }
    void OnTriggerExit(Collider col) 
    {

		
             int k=0;
               k= int.Parse(col.gameObject.name)-1;
            if(k>=0 && k<=25)   
       {
            nutritionImages[k].SetActive(false);
            selectedObj=-1;
            uiPannel.SetActive(false);
            selected=false;
            productNameTextBox.text="";
		
        }
    }



    
}
