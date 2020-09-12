using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LocationList : MonoBehaviour
{
    public List<Location> buildingsList = new List<Location>();
    // Start is called before the first frame update
    void Start()
    {
        buildingsList.Add(new Location("KF", 42.906396f, -85.857154f));
        buildingsList.Add(new Location("SA", 42.906680f, -85.830815f));
        buildingsList.Add(new Location("JCA", 42.921360f, -85.833188f));
        buildingsList.Add(new Location("HS", 42.920884f, -85.835952f));
        buildingsList.Add(new Location("JH", 42.919852f, -85.833167f));
        buildingsList.Add(new Location(("BA"), 42.921824f, -85.817425f));
        buildingsList.Add(new Location(("BU"), 42.889884f, -85.811507f));
        buildingsList.Add(new Location("PI", 42.911177f, -85.842848f));
        buildingsList.Add(new Location("RO", 42.899117f, -85.840849f));
        buildingsList.Add(new Location("JIA Connie", 42.909900f, -85.801412f));
        buildingsList.Add(new Location(("JIA Church"), 42.905225f, -85.788284f));
        buildingsList.Add(new Location("Transportation", 42.921992f, -85.812745f));



    }

    // Update is called once per frame
    void Update()
    {

    }


    public float MilesBetweenBuildings(string firstLoc, string secondLoc)
    {
        float miles = 0;
        string[] bothlocs = new string[] { firstLoc, secondLoc };

        //KF
        if (bothlocs.Contains("KF") && bothlocs.Contains("SA"))
            miles = 1.3f;

        if (bothlocs.Contains("KF") && bothlocs.Contains("JCA"))
            miles = 2.3f;

        if (bothlocs.Contains("KF") && bothlocs.Contains("HS"))
            miles = 2.1f;

        if (bothlocs.Contains("KF") && bothlocs.Contains("JH"))
            miles = 2.1f;

        if (bothlocs.Contains("KF") && bothlocs.Contains("BA"))
            miles = 3f;

        if (bothlocs.Contains("KF") && bothlocs.Contains("BU"))
            miles = 3.5f;

        if (bothlocs.Contains("KF") && bothlocs.Contains("PI"))
            miles = 1.3f;

        if (bothlocs.Contains("KF") && bothlocs.Contains("RO"))
            miles = 1.3f;

        if (bothlocs.Contains("KF") && bothlocs.Contains("Transportation"))
            miles = 1.3f;

        if (bothlocs.Contains("KF") && bothlocs.Contains("JIA Connie"))
            miles = 2.9f;

        if (bothlocs.Contains("KF") && bothlocs.Contains("JIA Church"))
            miles = 3.6f;

        //JCA
        if (bothlocs.Contains("JCA") && bothlocs.Contains("HS"))
            miles = .3f;

        if (bothlocs.Contains("JCA") && bothlocs.Contains("JH"))
            miles = .4f;

        if (bothlocs.Contains("JCA") && bothlocs.Contains("BA"))
            miles = .9f;

        if (bothlocs.Contains("JCA") && bothlocs.Contains("BU"))
            miles = 3.2f;

        if (bothlocs.Contains("JCA") && bothlocs.Contains("PI"))
            miles = 1.2f;

        if (bothlocs.Contains("JCA") && bothlocs.Contains("RO"))
            miles = 1.9f;

        if (bothlocs.Contains("JCA") && bothlocs.Contains("SA"))
            miles = 1f;

        if (bothlocs.Contains("JCA") && bothlocs.Contains("Transportation"))
            miles = 1.2f;

        if (bothlocs.Contains("JCA") && bothlocs.Contains("JIA Connie"))
            miles = 2.6f;

        if (bothlocs.Contains("JCA") && bothlocs.Contains("JIA Church"))
            miles = 2.9f;


        //HS
        if (bothlocs.Contains("HS") && bothlocs.Contains("JH"))
            miles = .5f;

        if (bothlocs.Contains("HS") && bothlocs.Contains("BA"))
            miles = 1.1f;

        if (bothlocs.Contains("HS") && bothlocs.Contains("BU"))
            miles = 3.5f;

        if (bothlocs.Contains("HS") && bothlocs.Contains("PI"))
            miles = 1.2f;

        if (bothlocs.Contains("HS") && bothlocs.Contains("RO"))
            miles = 2.3f;

        if (bothlocs.Contains("HS") && bothlocs.Contains("SA"))
            miles = 1.4f;

        if (bothlocs.Contains("HS") && bothlocs.Contains("Transportation"))
            miles = 1.3f;

        if (bothlocs.Contains("HS") && bothlocs.Contains("JIA Connie"))
            miles = 3f;

        if (bothlocs.Contains("HS") && bothlocs.Contains("JIA Church"))
            miles = 3f;

        //JH
        if (bothlocs.Contains("JH") && bothlocs.Contains("BA"))
            miles = 1f;

        if (bothlocs.Contains("JH") && bothlocs.Contains("BU"))
            miles = 3.1f;

        if (bothlocs.Contains("JH") && bothlocs.Contains("PI"))
            miles = 1.2f;

        if (bothlocs.Contains("JH") && bothlocs.Contains("RO"))
            miles = 1.9f;

        if (bothlocs.Contains("JH") && bothlocs.Contains("SA"))
            miles = .9f;

        if (bothlocs.Contains("JH") && bothlocs.Contains("Transportation"))
            miles = 1.2f;

        if (bothlocs.Contains("JH") && bothlocs.Contains("JIA Connie"))
            miles = 2.6f;

        if (bothlocs.Contains("JH") && bothlocs.Contains("JIA Church"))
            miles = 2.9f;

        if (bothlocs.Contains("JH") && bothlocs.Contains("HS"))
            miles = .3f;

        //BA

        if (bothlocs.Contains("BA") && bothlocs.Contains("BU"))
            miles = 3.8f;

        if (bothlocs.Contains("BA") && bothlocs.Contains("PI"))
            miles = 2.1f;

        if (bothlocs.Contains("BA") && bothlocs.Contains("RO"))
            miles = 2.8f;

        if (bothlocs.Contains("BA") && bothlocs.Contains("SA"))
            miles = 1.9f;

        if (bothlocs.Contains("BA") && bothlocs.Contains("Transportation"))
            miles = .2f;

        if (bothlocs.Contains("BA") && bothlocs.Contains("JIA Connie"))
            miles = 2.4f;

        if (bothlocs.Contains("BA") && bothlocs.Contains("JIA Church"))
            miles = 2f;

        //BU

        if (bothlocs.Contains("BU") && bothlocs.Contains("PI"))
            miles = 3.1f;

        if (bothlocs.Contains("BU") && bothlocs.Contains("RO"))
            miles = 2.3f;

        if (bothlocs.Contains("BU") && bothlocs.Contains("SA"))
            miles = 2.3f;

        if (bothlocs.Contains("BU") && bothlocs.Contains("Transportation"))
            miles = 2.6f;

        if (bothlocs.Contains("BU") && bothlocs.Contains("JIA Connie"))
            miles = 2f;

        if (bothlocs.Contains("BU") && bothlocs.Contains("JIA Church"))
            miles = 2.4f;

        //PI

        if (bothlocs.Contains("PI") && bothlocs.Contains("RO"))
            miles = 1.3f;

        if (bothlocs.Contains("PI") && bothlocs.Contains("SA"))
            miles = .9f;

        if (bothlocs.Contains("PI") && bothlocs.Contains("Transportation"))
            miles = 2.3f;

        if (bothlocs.Contains("PI") && bothlocs.Contains("JIA Connie"))
            miles = 2.6f;

        if (bothlocs.Contains("PI") && bothlocs.Contains("JIA Church"))
            miles = 3.2f;

        //RO
        if (bothlocs.Contains("RO") && bothlocs.Contains("SA"))
            miles = 1.1f;

        if (bothlocs.Contains("RO") && bothlocs.Contains("Transportation"))
            miles = 3f;

        if (bothlocs.Contains("RO") && bothlocs.Contains("JIA Connie"))
            miles = 2.7f;

        if (bothlocs.Contains("RO") && bothlocs.Contains("JIA Church"))
            miles = 3.4f;

        //SA
        if (bothlocs.Contains("SA") && bothlocs.Contains("Transportation"))
            miles = 2.4f;

        if (bothlocs.Contains("SA") && bothlocs.Contains("JIA Connie"))
            miles = 1.7f;

        if (bothlocs.Contains("SA") && bothlocs.Contains("JIA Church"))
            miles = 2.3f;


        //Transportation
        if (bothlocs.Contains("Transportation") && bothlocs.Contains("JIA Connie"))
            miles = 2.3f;

        if (bothlocs.Contains("Transportation") && bothlocs.Contains("JIA Church"))
            miles = 2.3f;

        //JIA Connie
        if (bothlocs.Contains("JIA Connie") && bothlocs.Contains("JIA Church"))
            miles = 1.1f;


        return miles;
    }


}
