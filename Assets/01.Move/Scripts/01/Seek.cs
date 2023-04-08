using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 추격 : 
public class Seek : AgentBehaviour
{
    public override Steering GetSteering()
    {
        Steering steering = new Steering();
        steering.linear = target.transform.position - this.transform.position; // this 아닐수도 있음

        steering.linear.Normalize();
        steering.linear *= agent.maxAccel;

        return steering;
    }
}
