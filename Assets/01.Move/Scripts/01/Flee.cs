using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ȸ��
public class Flee : AgentBehaviour
{
    public override Steering GetSteering()
    {
        Steering steering = new Steering();
        steering.linear = this.transform.position - target.transform.position; // this �ƴҼ��� ����

        steering.linear.Normalize();
        steering.linear *= agent.maxAccel;

        return steering;
    }
}
