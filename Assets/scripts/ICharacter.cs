using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 5. ICharacter��� �������̽��� �������ֽð�, HpRegenV, MpRegenV, Attack �̶�� �������̽� �Լ��� �������ּ���.
// �ش� �������̽��� è�Ǿ� Ŭ������ ��ӹ޵��� ���ּ���.
// 6. �������̽� ������� �������ּ���.
public interface ICharacter
{
    void HpRegenV();
    void MpRegenV();
    void Attack();

}
