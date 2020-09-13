using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class DistanceCalc : MonoBehaviour
{
    public float clong, clat;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        if (!Permission.HasUserAuthorizedPermission(Permission.FineLocation)) //check if they allowed location.
            Permission.RequestUserPermission(Permission.FineLocation);

        // First, check if user has location service enabled
        if (!Input.location.isEnabledByUser)
            yield break;



        // Start service before querying location
        Input.location.Start();

        // Wait until service initializes
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        // Service didn't initialize in 20 seconds
        if (maxWait < 1)
        {
            Start();//retry
            print("Timed out");
            yield break;
        }

        // Connection has failed
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            Permission.RequestUserPermission(Permission.FineLocation); //ask to allow location services
            print("Unable to determine device location");
            yield break;
        }
    }

    // Update is called once per frame
    void Update()
    {
       /*
            if (!Permission.HasUserAuthorizedPermission(Permission.FineLocation)) //check if they allowed location.
            {
                Permission.RequestUserPermission(Permission.FineLocation);
                Start();
            }
            */

    }



    public Location CheckLocation()
    {
        if (Input.location.status == LocationServiceStatus.Running)
        {
            float closest=9999999999999;
            Location closestLocation = new Location("KF", 42.906396f, -85.857154f);

            clat = Input.location.lastData.latitude;
            clong = Input.location.lastData.longitude;

            for (int i = 0; i < gameObject.GetComponent<LocationList>().buildingsList.Count; i++) //loop through building list to chec kwhich is closest
            {
                float calcdistance = LatLongDistance(clat, gameObject.GetComponent<LocationList>().buildingsList[i].coordx, clong, gameObject.GetComponent<LocationList>().buildingsList[i].coordy);
                if (calcdistance<closest)
                {
                    closest = calcdistance;
                    closestLocation = gameObject.GetComponent<LocationList>().buildingsList[i];
                }
            }
            if(closest<500)
            {
                return closestLocation;
            }
        }
        return null;
    }

    private float LatLongDistance(float lat_1, float lat_2, float long_1, float long_2)
    {
        int R = 6371;

        var lat_rad_1 = Mathf.Deg2Rad * lat_1;
        var lat_rad_2 = Mathf.Deg2Rad * lat_2;
        var d_lat_rad = Mathf.Deg2Rad * (lat_2 - lat_1);
        var d_long_rad = Mathf.Deg2Rad * (long_2 - long_1);
        var a = Mathf.Pow(Mathf.Sin(d_lat_rad / 2), 2) + (Mathf.Pow(Mathf.Sin(d_long_rad / 2), 2) * Mathf.Cos(lat_rad_1) * Mathf.Cos(lat_rad_2));
        var c = 2 * Mathf.Atan2(Mathf.Sqrt(a), Mathf.Sqrt(1 - a));
        var total_dist = R * c * 1000; // convert to meters
        return total_dist;
    }
}
