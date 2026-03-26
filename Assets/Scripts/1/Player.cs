using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool one;
    public bool two;
    public bool three;
    public bool four;
    public bool five;
    public bool six;
    public bool seven;
    public bool eight;
    public bool nine;
    public bool ten;
    public bool eleven;
    public bool twelve;
    public bool thirteen;
    public bool fourteen;
    public bool fifteen;
    public bool sixteen;
    public bool seventeen;
    public bool eighteen;
    public bool nineteen;
    public bool twenty;
    public bool twentyone;
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        DataPlayer data = SaveSystem.LoadPlayer();
        one=data.one;
        two=data.two;
        three=data.three;
        four=data.four;
        five=data.five;
        six=data.six;
        seven=data.seven;
        eight=data.eight;
        nine=data.nine;
        ten=data.ten;
        eleven=data.eleven;
        twelve=data.twelve;
        thirteen=data.thirteen;
        fourteen=data.fourteen;
        fifteen=data.fifteen;
        sixteen=data.sixteen;
        seventeen=data.seventeen;
        eighteen=data.eighteen;
        nineteen=data.nineteen;
        twenty=data.twenty;
        twentyone=data.twentyone;
    }
    void Update()
    {
        if (completion.onecomplete==true)
        {
            one=true;
        }
       if (completion.twocomplete==true)
        {
            two=true;
        }
       if (completion.threecomplete==true)
        {
            three=true;
        }
        if (completion.fourcomplete==true)
        {
            four=true;
        }
       if (completion.fivecomplete==true)
        {
            five=true;
        }
       if (completion.sixcomplete==true)
        {
            six=true;
        }
        if (completion.sevencomplete==true)
        {
            seven=true;
        }
       if (completion.eightcomplete==true)
        {
            eight=true;
        }
       if (completion2.ninecomplete==true)
        {
            nine=true;
        }
        if (completion2.tencomplete==true)
        {
            ten=true;
        }
       if (completion2.elevencomplete==true)
        {
            eleven=true;
        }
       if (completion2.twelvecomplete==true)
        {
            twelve=true;
        }
       if (completion2.thirteencomplete==true)
        {
            thirteen=true;
        }
        if (completion2.fourteencomplete==true)
        {
            fourteen=true;
        }
       if (completion2.fifteencomplete==true)
        {
            fifteen=true;
        }
       if (completion3.sixteencomplete==true)
        {
            sixteen=true;
        }
           if (completion3.seventeencomplete==true)
        {
            seventeen=true;
        }
        if (completion3.eighteencomplete==true)
        {
            eighteen=true;
        }
       if (completion3.nineteencomplete==true)
        {
            nineteen=true;
        }
       if (completion3.twentycomplete==true)
        {
            twenty=true;
        }
       if (completion3.twentyonecomplete==true)
        {
            twentyone=true;
        }



        if (one==true)
        {
            completion.onecomplete=true;
        }
        if (two==true)
        {
            completion.twocomplete=true;
        }
        if (three==true)
        {
            completion.threecomplete=true;
        }
        if (four==true)
        {
            completion.fourcomplete=true;
        }
        if (five==true)
        {
            completion.fivecomplete=true;
        }
        if (six==true)
        {
            completion.sixcomplete=true;
        }
        if (seven==true)
        {
            completion.sevencomplete=true;
        }
        if (eight==true)
        {
            completion.eightcomplete=true;
        }
        if (nine==true)
        {
            completion2.ninecomplete=true;
        }
        if (ten==true)
        {
            completion2.tencomplete=true;
        }
        if (eleven==true)
        {
            completion2.elevencomplete=true;
        }
        if (twelve==true)
        {
            completion2.twelvecomplete=true;
        }
        if (thirteen==true)
        {
            completion2.thirteencomplete=true;
        }
        if (fourteen==true)
        {
            completion2.fourteencomplete=true;
        }
        if (fifteen==true)
        {
            completion2.fifteencomplete=true;
        }
        if (sixteen==true)
        {
            completion3.sixteencomplete=true;
        }
        if (seventeen==true)
        {
            completion3.seventeencomplete=true;
        }
        if (eighteen==true)
        {
            completion3.eighteencomplete=true;
        }
        if (nineteen==true)
        {
            completion3.nineteencomplete=true;
        }
        if (twenty==true)
        {
            completion3.twentycomplete=true;
        }
        if (twentyone==true)
        {
            completion3.twentyonecomplete=true;
        }
    }
}
