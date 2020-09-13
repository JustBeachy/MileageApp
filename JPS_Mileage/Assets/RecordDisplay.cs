using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordDisplay : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {

        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<SaveLoad>().LoadList();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
