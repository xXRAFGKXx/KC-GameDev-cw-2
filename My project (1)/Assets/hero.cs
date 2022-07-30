using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string heroname = "5osh wld";
        int heroheight = 180;
        int heroage = 26;
        string heropower = "water control";
        string villainname = "bo 5shm";
        int villainheight = 280;
        int villainage  = 60;
        string villainpower = "flames";
        int ageDifference = heroage - villainage;
        print("heroname is " + heroname + " and his height is " + heroheight + " and his age is" + heroage + " and his power is " + heropower + " villainname is " + villainname + " and his height is " + villainheight + " and his age is " + villainage + " and his power is " + villainpower);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
