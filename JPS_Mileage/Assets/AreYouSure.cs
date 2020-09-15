using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class AreYouSure : MonoBehaviour
{
    public GameObject attachedObject;
    public Text recordPreview;
    
    // Start is called before the first frame update
    void Start()
    {
        if (attachedObject != null)
        {
            ListItem s = attachedObject.GetComponent<ListItem>();
            recordPreview.text = s.date.text + "    " + s.location.text + "    " + s.miles.text;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeleteRecord()
    {
        attachedObject.GetComponent<ListItem>().DeleteRecord();
        Destroy(gameObject);

        
    }

    public void DeleteAll()
    {
        string filePath = Application.persistentDataPath + "/Save_Data.csv";
        File.WriteAllText(filePath, "Date, Location, Miles\n"); //save over everything, deleting it all
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<SaveLoad>().Load();
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<SaveLoad>().LoadList();
        GameObject.FindGameObjectWithTag("Total").GetComponent<TotalMiles>().CalculateTotal();
        Destroy(gameObject);
    }

    public void Cancel()
    {
        Destroy(gameObject);
    }
}
