using System;
using UnityEngine;

// 1. Champion Ŭ������ �߻� Ŭ������ ������ּ���.
// ������ �־���� ������ Name / HP / MP / AttckDamage / Armor / HPRegen / MPRegen �̸� Name(string)�� �����ϰ�
// ��� float �Դϴ�.

// 2. Champion Ŭ������ SkillQ / SkillW / SkillE / SkillR �� �߻�޼ҵ�� ������ּ���.
// 3. Champion Ŭ������ ��ӹ޴� ���� ĳ�����̸��� Ŭ������ ������ּ���.
// ��ӹ��� �߻� �޼ҵ� ���� ���� �������ּ���.



public abstract class Champion : ICharacter
{
    public float Hp = 0;
    public float HpRegen = 0;
    public float Mp = 0;
    public float MpRegen = 0;
    public float AttckDamage = 0;
    public float Armor = 0;
    public string Name = "";

    public abstract void SkillQ();
    public abstract void SkillW(); 
    public abstract void SkillE();
    public abstract void SkillR();


    public void HpRegenV()
    {
        HpRegen += Hp;
    }

    public void MpRegenV()
    {
        MpRegen += Mp; 
    }

    public void Attack()
    {
        AttckDamage = Armor - AttckDamage;
    }
}
