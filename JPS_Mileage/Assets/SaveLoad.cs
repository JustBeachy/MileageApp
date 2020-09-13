using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using System;
using UnityEngine.UI;

public class SaveLoad : MonoBehaviour
{
    public List<string> dateList, locList, mileList;
    string filePath = "";
    DateTime dt;
    public Text notificationTxt;
    public GameObject ListItem;
    public Dropdown dropMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        
        filePath = Application.persistentDataPath + "/Save_Data.csv";
        Load();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RecordLocation(bool ismanual=false)
    {
        string currentLocation = "";
        dt = DateTime.Now;
        if (!ismanual)
            currentLocation = GetComponent<DistanceCalc>().CheckLocation().Bname; //change for testing
        else
            currentLocation = dropMenu.options[dropMenu.value].text;

            if (locList[locList.Count - 1] != currentLocation) //if not the same location 
            {
                if (dateList[dateList.Count - 1] == dt.ToString("MMMM dd")) //if previous data's date is the same day.
                    mileList.Add(GetComponent<LocationList>().MilesBetweenBuildings(currentLocation, locList[locList.Count - 1]).ToString());
                else
                    mileList.Add("0"); //must be first of the day

                locList.Add(currentLocation);


                dateList.Add(dt.ToString("MMMM dd"));

                notificationTxt.text = currentLocation + " location Recorded!";

                Save();
            }
            else //message if same location
                notificationTxt.text = currentLocation + " was already recorded as the most recent location.";
        
       

    }

    public void Save()
    {
        string saveString = "";

        if (File.Exists(@filePath))
        {


            for (int i = 0; i < dateList.Count; i++)
            {
                saveString += dateList[i] + ",";
                saveString += locList[i] + ",";
                saveString += mileList[i] + "\n";
            }
            File.WriteAllText(filePath, saveString);
        }
        else
        {
            saveString = "Date, Location, Miles\n";
            File.WriteAllText(filePath, saveString);
            Load();
        }
        
    }


    public void Load()
    {
        if (File.Exists(@filePath))
        {
            string loadString = File.ReadAllText(filePath, Encoding.UTF8);

            string[] loadStringArray = loadString.Split('\n');


            dateList.Clear();
            dateList.TrimExcess();
            locList.Clear();
            locList.TrimExcess();
            mileList.Clear();
            mileList.TrimExcess();

            for (int i = 0; i < loadStringArray.Length - 1; i++)
            {
                dateList.Add(loadStringArray[i].Split(',')[0]);
                locList.Add(loadStringArray[i].Split(',')[1]);
                mileList.Add(loadStringArray[i].Split(',')[2]);
            }
        }
        else
            Save();

    }

    public void LoadList()
    {
        GameObject content = GameObject.FindGameObjectWithTag("Content");

        for (int i = locList.Count-1; i >= 1; i--)
        {
            var newItem = Instantiate(ListItem, content.transform);
            newItem.GetComponent<ListItem>().date.text = dateList[i];
            newItem.GetComponent<ListItem>().location.text = locList[i];
            newItem.GetComponent<ListItem>().miles.text = mileList[i];
            newItem.GetComponent<ListItem>().index = i;
        }
    }
}
