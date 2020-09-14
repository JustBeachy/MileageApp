using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListItem : MonoBehaviour
{
    public Text date, location, miles;
    public int index;
    public GameObject deleteButton;
    public GameObject areYouSure;
    // Start is called before the first frame update
    void Start()
    {
        if (index != GameObject.FindGameObjectWithTag("MainCamera").GetComponent<SaveLoad>().locList.Count - 1)//if it's not to on the list, remove the delete button.
            deleteButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeleteRecord()
    {
        SaveLoad mc = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<SaveLoad>();

        mc.locList.RemoveAt(index);
        mc.dateList.RemoveAt(index);
        mc.mileList.RemoveAt(index);

        Destroy(gameObject);

        mc.Save();

        mc.LoadList(); //reload indexes after deleting.
        GameObject.FindGameObjectWithTag("Total").GetComponent<TotalMiles>().CalculateTotal();
    }

    public void AYSPopup()
    {
        var makePopup =Instantiate(areYouSure, GameObject.FindGameObjectWithTag("Canvas").transform);
        makePopup.GetComponent<AreYouSure>().attachedObject = gameObject;
    }
}
