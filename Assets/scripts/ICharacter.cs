using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 5. ICharacter라는 인터페이스를 생성해주시고, HpRegenV, MpRegenV, Attack 이라는 인터페이스 함수를 선언해주세요.
// 해당 인터페이스는 챔피언 클래스가 상속받도록 해주세요.
// 6. 인터페이스 내용들을 구현해주세요.
public interface ICharacter
{
    void HpRegenV();
    void MpRegenV();
    void Attack();

}
