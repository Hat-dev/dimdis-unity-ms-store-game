using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class completion3 : MonoBehaviour
{
    public Image sixteenfinish;
    public Image seventeenfinish;
    public Image eighteenfinish;
    public Image nineteenfinish;
    public Image twentyfinish;
    public Image twentyonefinish;

    public bool finished;
    public static bool sixteencomplete;
    public static bool seventeencomplete;
    public static bool eighteencomplete;
    public static bool nineteencomplete;
    public static bool twentycomplete;
    public static bool twentyonecomplete;

    
    private bool sixteenandseventeen;
    private bool eighteenandnineteen;
    private bool twentyandtwentyone;

    private bool firstfour;

    void Update()
    {
        if (sixteencomplete==true)
        {
            sixteenfinish.enabled=true;
        }
        if (seventeencomplete==true)
        {
            seventeenfinish.enabled=true;
        }
        if (eighteencomplete==true)
        {
            eighteenfinish.enabled=true;
        }
        if (nineteencomplete==true)
        {
            nineteenfinish.enabled=true;
        }
        if (twentycomplete==true)
        {
            twentyfinish.enabled=true;
        }
        if (twentyonecomplete==true)
        {
            twentyonefinish.enabled=true;
        }


        if ((sixteencomplete==true) && (seventeencomplete==true))
        {
            sixteenandseventeen=true;
        }
        if ((eighteencomplete==true) && (nineteencomplete==true))
        {
            eighteenandnineteen=true;
        }
        if ((twentycomplete==true) && (twentyonecomplete==true))
        {
            twentyandtwentyone=true;
        }

        if ((sixteenandseventeen==true)&&(eighteenandnineteen==true))
        {
            firstfour=true;
        }

        if ((firstfour==true)&&(twentyandtwentyone)==true)
        {
            finished=true;
        }
    }
}
