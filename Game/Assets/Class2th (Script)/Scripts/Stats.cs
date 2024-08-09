using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data
{
    private int health;
    protected string name;

    public Data(int health, string name)
    {
        this.health = health;
        this.name = name;
    }
}

public class Stats
{
    Data data = new Data(100, "Dinosaur");
    public int attack = 30;

    void Start()
    {
        Debug.Log("attack 변수의 값 : " + attack);
    }
}
