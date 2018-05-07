using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PL
{
    private int HP = 100;
    private int power = 50;

    public void Attack()
    {
        Debug.Log(power + "のダメージを与えた");
    }
    public void Damage(int damage)
    {
        HP -= damage;
        Debug.Log(damage + "のダメージを受けた");
    }
}

public class Class : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
        PL MyPL = new PL();
        MyPL.Attack();
        MyPL.Damage(30);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
