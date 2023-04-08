using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 회피
public class Flee : AgentBehaviour
{
    public override Steering GetSteering()
    {
        Steering steering = new Steering();
        steering.linear = this.transform.position - target.transform.position; // this 아닐수도 있음

        steering.linear.Normalize();
        steering.linear *= agent.maxAccel;

        return steering;
    }
}
