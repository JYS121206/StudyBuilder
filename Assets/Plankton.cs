using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plankton : MonoBehaviour //외부요소
{
    McDonald mcDonald = new();
    Hamburger cheeseBurger;

    void Start()
    {
        //치즈버거 주문
        cheeseBurger = new();

        //치즈버거 확인
        print("플랑크톤: 주문한 버거를 확인해볼까?\n ");
        Check(cheeseBurger.Pickle);
    }

    void Check(bool isTrue)
    {
        print($"[피클의 상태: {isTrue}]\n ");

        if (isTrue)
        {
            print("플랑크톤: 멀쩡하잖아!\n ");
            print($"스폰지밥: 뭐가 문제요?\n ");
        }
        else
        {
            print("플랑크톤: 이봐! 치즈버거에 피클이 없잖아!\n ");
            print("스폰지밥: 분명 확인했는데 어디갔담?\n ");
            print("플랑크톤: 환불해줘!\n ");
        }
    }
}
