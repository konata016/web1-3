using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    //オリジナル1
    void SayHello()
    {
        Debug.Log("ハロー");
    }

    //オリジナル2
    void CallName(string name)
    {
        Debug.Log("へーーい" + name);
    }

    //オリジナル3
    int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }


    // Use this for initialization
    void Start () {
        //配列
        int[] array = new int[5];

        array[0] = 2;
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        for(int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }


        //簡単な初期化
        int[] points = { 93, 99, 52, 93, 15 };

        for(int i = 0; i < points.Length; i++)
        {
            Debug.Log(points[i]);
        }


        //引数も返り値もないメソッド
        SayHello();


        //引数のあるメソッド
        CallName("とむむむ");


        //引数と返り値のあるメソッド
        int answer;
        answer = Add(2, 3);
        Debug.Log(answer);


        //
    }

    // Update is called once per frame
    void Update () {
		
	}

}
