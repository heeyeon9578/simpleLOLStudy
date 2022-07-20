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

            // (보너스 문제) 4. 하기의 내용을 참고하여 캐릭터이름을 사용한 클래스를 선언 및 인스턴스화 해주세요
            // 인스턴싱한 내용은 cArray에 담아주세요.
            // https://docs.microsoft.com/en-us/dotnet/api/System.Activator?view=net-6.0
            // Hint : 현재 Json안에 챔피언의 id는 첫 글자가 소문자 입니다.이를 유의하여 선언해주세요.

            //ch.id의 type을 가져오는 데, 이때 Type. 을 꼭 해주어야 함.
            Type type = Type.GetType(ch.id);
            Champion cham = (Champion)Activator.CreateInstance(type);

            cArray[idx++] = cham;
        }
        // 7. cArray에 담긴 인스턴스들의 Q Skill을 발동하는 코드를 작성해주세요.
        for (int i = 0; i < cArray.Length; i++)
            cArray[i].SkillQ();
            


        
    }
}
