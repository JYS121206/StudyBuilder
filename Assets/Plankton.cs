using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plankton : MonoBehaviour //�ܺο��
{
    McDonald mcDonald = new();
    Hamburger cheeseBurger;

    void Start()
    {
        //ġ����� �ֹ�
        cheeseBurger = new();

        //ġ����� Ȯ��
        print("�ö�ũ��: �ֹ��� ���Ÿ� Ȯ���غ���?\n ");
        Check(cheeseBurger.Pickle);
    }

    void Check(bool isTrue)
    {
        print($"[��Ŭ�� ����: {isTrue}]\n ");

        if (isTrue)
        {
            print("�ö�ũ��: �������ݾ�!\n ");
            print($"��������: ���� ������?\n ");
        }
        else
        {
            print("�ö�ũ��: �̺�! ġ����ſ� ��Ŭ�� ���ݾ�!\n ");
            print("��������: �и� Ȯ���ߴµ� ��𰬴�?\n ");
            print("�ö�ũ��: ȯ������!\n ");
        }
    }
}
