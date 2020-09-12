using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using System;

public class SaveLoad : MonoBehaviour
{
    public List<string> dateList, locList, mileList;
    string filePath = "";
    DateTime dt;
    
    // Start is called before the first frame update
    void Start()
    {
        filePath = Application.persistentDataPath + "/Save_Data.csv";

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RecordLocation()
    {

        dt = DateTime.Now;
        string currentLocation = "KF";//GetComponent<DistanceCalc>().CheckLocation().Bname; //change for testing

        if (locList[locList.Count - 1] != currentLocation) //if not the same location //maybe add message prompt?
        {
            if (dateList[dateList.Count - 1] == dt.ToString("MMMM dd")) //if previous data's date is the same day.
                mileList.Add(GetComponent<LocationList>().MilesBetweenBuildings(currentLocation, locList[locList.Count - 1]).ToString());
            else
                mileList.Add("0"); //must be first of the day

            locList.Add(currentLocation);

            
            dateList.Add(dt.ToString("MMMM dd"));

            Save();
        }

    }

    public void Save()
    {
        string saveString = "";

        for(int i=0;i<dateList.Count;i++)
        {
            saveString += dateList[i] + ",";
            saveString += locList[i] + ",";
            saveString += mileList[i] + "\n";    
        }

        File.WriteAllText(filePath, saveString);
    }


    public void Load()
    {
        string loadString = File.ReadAllText(filePath, Encoding.UTF8);

        string[] loadStringArray = loadString.Split('\n');
        

        dateList.Clear();
        dateList.TrimExcess();
        locList.Clear();
        locList.TrimExcess();
        mileList.Clear();
        mileList.TrimExcess();

        for(int i=0;i<loadStringArray.Length-1;i++)
        {
                dateList.Add(loadStringArray[i].Split(',')[0]);
                locList.Add(loadStringArray[i].Split(',')[1]);
                mileList.Add(loadStringArray[i].Split(',')[2]);
        }

    }
}
