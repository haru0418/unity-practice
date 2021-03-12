using UnityEngine;

public class PlayerModel
{
    // string name = "haruyuki"; 
    string name;
    int hp;
    int at;

    // 生成されたときに呼び出される
    public PlayerModel()
    {
        name = "haruyuki";
    }

    public PlayerModel(string name)
    {
        this.name = name;
    }


    public void SayName()
    {
        Debug.Log(name);
    }
}
