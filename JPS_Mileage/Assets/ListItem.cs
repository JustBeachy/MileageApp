using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListItem : MonoBehaviour
{
    public Text date, location, miles;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        
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
    }
}
