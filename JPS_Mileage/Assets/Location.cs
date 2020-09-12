using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    public string Bname;
    public float coordx, coordy;

   public Location(string Name, float Coordx, float Coordy)
    {
        Bname = Name;
        coordx = Coordx;
        coordy = Coordy;
    }

    
}
