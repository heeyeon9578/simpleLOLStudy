using System;
using UnityEngine;
using System.Reflection;

[Serializable] 
public class ChampionClasses
{
    public ChampionClass[] champs;
}

[Serializable]
public class ChampionClass
{
    public string id;
    public string key;
    public string name;
    public string title;
    public string[] tags;
    public Stats stats;
    public string icon;
    public SpriteC sprite;
    public string description;
    
}

[Serializable]
public class SpriteC
{
    public string url;
    public int x;
    public int y;
}

[Serializable]
public class Stats
{
    public int hp;
    public int hpperlevel;
    public int mp;
    public int mpperlevel;
    public float movespeed;
    public float armor;
    public float armorperlevel;
    public float spellblock;
    public float spellblockperlevel;
    public float attackrange;
    public float hpregen;
    public float hpregenperlevel;
    public float mpregen;
    public float mpregenperlevel;
    public float crit;
    public float critperlevel;
    public float attackdamage;
    public float attackdamageperlevel;
    public float attackspeedperlevel;
    public float attackspeed;
}



public class JsonManager : MonoBehaviour
{
    public TextAsset textAsset;
    void Start()
    {
        
        Debug.Log(textAsset.text);
        ChampionClasses c = new ChampionClasses();
        c = JsonUtility.FromJson<ChampionClasses>(textAsset.text);
        Champion[] cArray = new Champion[6];
        int idx = 0;
       
        
        foreach (var ch in c.champs)
        {

            // (���ʽ� ����) 4. �ϱ��� ������ �����Ͽ� ĳ�����̸��� ����� Ŭ������ ���� �� �ν��Ͻ�ȭ ���ּ���
            // �ν��Ͻ��� ������ cArray�� ����ּ���.
            // https://docs.microsoft.com/en-us/dotnet/api/System.Activator?view=net-6.0
            // Hint : ���� Json�ȿ� è�Ǿ��� id�� ù ���ڰ� �ҹ��� �Դϴ�.�̸� �����Ͽ� �������ּ���.

            //ch.id�� type�� �������� ��, �̶� Type. �� �� ���־�� ��.
            Type type = Type.GetType(ch.id);
            Champion cham = (Champion)Activator.CreateInstance(type);

            cArray[idx++] = cham;
        }
        // 7. cArray�� ��� �ν��Ͻ����� Q Skill�� �ߵ��ϴ� �ڵ带 �ۼ����ּ���.
        for (int i = 0; i < cArray.Length; i++)
            cArray[i].SkillQ();
            


        
    }
}
