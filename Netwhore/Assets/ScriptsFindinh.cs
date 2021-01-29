using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptsFindinh : MonoBehaviour
{

    public InputField inputField;
    public Text Result; 
   
    
    
    public void finding()
    {
        var Word = new List<string>() { "Nice", "Inuit", "Guy", "Giggle", "Aatrox" };
       foreach (string word in Word)
        {
            if (word == inputField.text)
            {
                Result.text = "<color=green>" + inputField.text + "</color>" + " is found";
                return;
            }
            else
            {
                Result.text = "<color=red>" + inputField.text + "</color>" + " is not found";
            }
        }
    }

    


   
       
    
       



    





}
