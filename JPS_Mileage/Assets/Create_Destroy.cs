using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Destroy : MonoBehaviour
{
    public GameObject ObjectToDestroy, ObjectToCreate, Canvas;

    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.FindGameObjectWithTag("Canvas");
    }

    public void CreateScreen()
    {
        Instantiate(ObjectToCreate, Canvas.transform);
    }

    public void DestroyScreen()
    {
        Destroy(ObjectToDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
