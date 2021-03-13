using UnityEngine;

public class PlayerModel
{
    // string name = "haruyuki"; 
    string name;
    int hp;
    int at;

    //プロパティ

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int HP
    {
        get { return hp; }
        set { hp = value; }
    }
    public int AT
    {
        get { return  at; }
        set { at = value; }
    }

    // 生成されたときに呼び出される
    public PlayerModel()
    {
        name = "haruyuki";
    }

    public PlayerModel(string name)
    {
        this.name = name;
        at = 100;
        hp = 150;
    }


    public void SayName()
    {
        Debug.Log(name);
    }
}
