using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pationt : GAgent
{
    // Start is called before the first frame update
    void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("isWaiting", 1, true);
        sgoals.Add(s1, 3);
    }

   
}
