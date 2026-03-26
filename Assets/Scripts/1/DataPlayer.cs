using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DataPlayer
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
    public DataPlayer (Player player)
    {
        one = player.one;
        two=player.two;
        three=player.three;
        four=player.four;
        five=player.five;
        six=player.six;
        seven = player.seven;
        eight=player.eight;
        nine=player.nine;
        ten=player.ten;
        eleven=player.eleven;
        twelve=player.twelve;
        thirteen=player.thirteen;
        fourteen=player.fourteen;
        fifteen=player.fifteen;
        sixteen=player.sixteen;
        seventeen = player.seventeen;
        eighteen=player.eighteen;
        nineteen=player.nineteen;
        twenty=player.twenty;
        twentyone=player.twentyone;
    }

}
