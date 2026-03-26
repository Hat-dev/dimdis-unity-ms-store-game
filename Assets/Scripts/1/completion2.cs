using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class completion2 : MonoBehaviour
{
    public Image ninefinish;
    public Image tenfinish;
    public Image elevenfinish;
    public Image twelvefinish;
    public Image thirteenfinish;
    public Image fourteenfinish;
    public Image fifteenfinish;

    public Button next;
    public Image arrow;

    public static bool ninecomplete;
    public static bool tencomplete;
    public static bool elevencomplete;
    public static bool twelvecomplete;
    public static bool thirteencomplete;
    public static bool fourteencomplete;
    public static bool fifteencomplete;
    
    private bool nineandten;
    private bool twelveandthirteen;
    private bool fourteenandfifteen;

    private bool firstthree;
    private bool lastfour;

    void Update()
    {
        if (ninecomplete==true)
        {
            ninefinish.enabled=true;
        }
        if (tencomplete==true)
        {
            tenfinish.enabled=true;
        }
        if (elevencomplete==true)
        {
            elevenfinish.enabled=true;
        }
        if (twelvecomplete==true)
        {
            twelvefinish.enabled=true;
        }
        if (thirteencomplete==true)
        {
            thirteenfinish.enabled=true;
        }
        if (fourteencomplete==true)
        {
            fourteenfinish.enabled=true;
        }
        if (fifteencomplete==true)
        {
            fifteenfinish.enabled=true;
        }


        if ((ninecomplete==true) && (tencomplete==true))
        {
            nineandten=true;
        }
        if ((twelvecomplete==true) && (thirteencomplete==true))
        {
            twelveandthirteen=true;
        }
        if ((fourteencomplete==true) && (fifteencomplete==true))
        {
            fourteenandfifteen=true;
        }

        if ((nineandten==true)&&(elevencomplete==true))
        {
            firstthree=true;
        }
        if ((twelveandthirteen==true)&&(fourteenandfifteen==true))
        {
            lastfour=true;
        }

        if ((firstthree==true)&&(lastfour)==true)
        {
            next.enabled=true;
            arrow.enabled=true;
        }
    }
}
