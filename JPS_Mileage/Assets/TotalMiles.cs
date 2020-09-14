using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalMiles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CalculateTotal();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CalculateTotal()
    {
        GameObject mc = GameObject.FindGameObjectWithTag("MainCamera");
        float holder = 0;
        for (int i = mc.GetComponent<SaveLoad>().mileList.Count - 1; i >= 1; i--)
        {
            holder += float.Parse(mc.GetComponent<SaveLoad>().mileList[i]);
        }
        GetComponent<Text>().text = "Total Miles: " + holder.ToString("0.0");
    }
}
