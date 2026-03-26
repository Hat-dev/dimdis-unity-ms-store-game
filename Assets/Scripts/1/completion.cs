using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class completion : MonoBehaviour
{
    public Image onefinish;
    public Image twofinish;
    public Image threefinish;
    public Image fourfinish;
    public Image fivefinish;
    public Image sixfinish;
    public Image sevenfinish;
    public Image eightfinish;

    public Button next;
    public Image arrow;

    public static bool onecomplete;
    public static bool twocomplete;
    public static bool threecomplete;
    public static bool fourcomplete;
    public static bool fivecomplete;
    public static bool sixcomplete;
    public static bool sevencomplete;
    public static bool eightcomplete;

    private bool oneandtwo;
    private bool threeandfour;
    private bool fiveandsix;
    private bool sevenandeight;

    private bool firstfour;
    private bool lastfour;

    void Update()
    {
        if (onecomplete==true)
        {
            onefinish.enabled=true;
        }
        if (twocomplete==true)
        {
            twofinish.enabled=true;
        }
        if (threecomplete==true)
        {
            threefinish.enabled=true;
        }
        if (fourcomplete==true)
        {
            fourfinish.enabled=true;
        }
        if (fivecomplete==true)
        {
            fivefinish.enabled=true;
        }
        if (sixcomplete==true)
        {
            sixfinish.enabled=true;
        }
        if (sevencomplete==true)
        {
            sevenfinish.enabled=true;
        }
        if (eightcomplete==true)
        {
            eightfinish.enabled=true;
        }


        if ((onecomplete==true) && (twocomplete==true))
        {
            oneandtwo=true;
        }
        if ((threecomplete==true) && (fourcomplete==true))
        {
            threeandfour=true;
        }
        if ((fivecomplete==true) && (sixcomplete==true))
        {
            fiveandsix=true;
        }
        if ((sevencomplete==true) && (eightcomplete==true))
        {
            sevenandeight=true;
        }

        if ((oneandtwo==true)&&(threeandfour==true))
        {
            firstfour=true;
        }
        if ((fiveandsix==true)&&(sevenandeight==true))
        {
            lastfour=true;
        }

        if ((firstfour==true)&&(lastfour)==true)
        {
            next.enabled=true;
            arrow.enabled=true;
        }
    }
}
