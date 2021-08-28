using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int HealthScore = 10;
    public Text HealtText;
    
    // Start is called before the first frame update
    void Start()
    {
        UpdateText();
    }

    public int  RemoveOneHealth()
    {
        HealthScore -= 1;
        UpdateText();
        return HealthScore;
        
    }
    void UpdateText()
    {
        HealtText.text = "Броня : " + HealthScore.ToString();
    }

}
