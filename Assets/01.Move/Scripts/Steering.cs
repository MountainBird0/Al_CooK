using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 에이전트의 이동 및 회전을 저장하기 위한 사용자 정의 데이터 역할
public class Steering : MonoBehaviour
{
    public float angular;
    public Vector3 linear;

    public Steering()
    {
        angular = 0.0f;
        linear = new Vector3();
    }

}
