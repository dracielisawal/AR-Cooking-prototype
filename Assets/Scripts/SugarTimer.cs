using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SugarTimer : MonoBehaviour
{
    public float sugartimeLeft = 5;
    public float milktimeleft = 10;
    public Text sugertimer;
    public Text boilTimer;
    public bool isSugarThere = false;
    public bool isPanThere = false;
    public bool isMilkThere = false;
    public GameObject overHeat; 

    public GameObject toomuchSugar;
    public GameObject LevelComplete;

  

   public void onSugarFound()
    {
        isSugarThere = true;
    } 

    public void onSugarLost()
    {
        isSugarThere = false;
        if (toomuchSugar.activeSelf == true)
        {
            toomuchSugar.gameObject.SetActive(false);
        }
        
    }

    public void onPanFound()
    {
        isPanThere = true;
    } 

    public void onPanLost()
    {
        isPanThere = false;
        if(overHeat.activeSelf == true)
        {
            overHeat.SetActive(false);
        }
            
        
    }

    public void onMilkFound()
    {
        isMilkThere = true;
    } 

    public void onMilkLost()
    {
       isMilkThere = false;
        
    }



    private void Update()
    {


        if (isPanThere)
        {
            if (isMilkThere)
            {

              
                
                    milktimeleft -= Time.deltaTime;
                int milktime = (int)milktimeleft;
                
                    boilTimer.text = " Boil for : " + milktime.ToString(); 

            if(milktimeleft<=0)
                {
                    boilTimer.text = "Done";
                    overHeat.gameObject.SetActive(true);

                }
                
               
                
            
            }
        } 

        if(isMilkThere&&isSugarThere)
        {
            sugartimeLeft -= Time.deltaTime;
            int pourtime = (int)sugartimeLeft;
            sugertimer.text = "Pour for : " + pourtime.ToString();

            if (sugartimeLeft <= 0)
            {
                sugertimer.text = "Done";
                toomuchSugar.gameObject.SetActive(true);
            }
        } 
 
        if(sugartimeLeft <=0  && milktimeleft <= 0 &&isPanThere == false && isSugarThere == false)
        {
            LevelComplete.gameObject.SetActive(true);
        }
        

    }

      
            
            
            


        
      

}
