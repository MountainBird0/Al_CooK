using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������Ʈ�� �̵� �� ȸ���� �����ϱ� ���� ����� ���� ������ ����
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
