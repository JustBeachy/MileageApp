using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AreYouSure : MonoBehaviour
{
    public GameObject attachedObject;
    public Text recordPreview;
    
    // Start is called before the first frame update
    void Start()
    {
        ListItem s = attachedObject.GetComponent<ListItem>();
        recordPreview.text = s.date.text + "    " + s.location.text + "    " + s.miles.text;
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

    public void Cancel()
    {
        Destroy(gameObject);
    }
}
