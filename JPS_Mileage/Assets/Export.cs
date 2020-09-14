using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Export : MonoBehaviour
{
    NativeShare ns;
    SaveLoad mc;
    // Start is called before the first frame update
    void Start()
    {
        ns = new NativeShare();
        mc = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<SaveLoad>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExportData()
    {
        string saveString = "";
        saveString +="\n"+ GameObject.FindGameObjectWithTag("Total").GetComponent<Text>().text+"\n\n"; //add total to beginning

        for (int i =0; i< mc.locList.Count;  i++)
        {
            saveString += mc.dateList[i] + ",";
            saveString += mc.locList[i] + ",";
            saveString += mc.mileList[i] + "\n";
        }
        saveString += GameObject.FindGameObjectWithTag("Total").GetComponent<Text>().text + "\n"; //add total to end

        ns.SetTitle("Mileage Records");
        ns.SetSubject("Mileage Records");
        ns.SetText(saveString);

        ns.Share();
    }
}
