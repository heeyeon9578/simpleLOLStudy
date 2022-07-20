using System;
using UnityEngine;

// 1. Champion 클래스를 추상 클래스로 만들어주세요.
// 가지고 있어야할 내용은 Name / HP / MP / AttckDamage / Armor / HPRegen / MPRegen 이며 Name(string)을 제외하고
// 모두 float 입니다.

// 2. Champion 클래스에 SkillQ / SkillW / SkillE / SkillR 을 추상메소드로 만들어주세요.
// 3. Champion 클래스를 상속받는 각각 캐릭터이름의 클래스를 만들어주세요.
// 상속받은 추상 메소드 내용 또한 구현해주세요.



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
