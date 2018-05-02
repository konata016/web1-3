using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

        //ようこそを出す
        Debug.Log("ようこそ");


        //変数の中身を出す
        int age;
        age = 30;
        Debug.Log(age);


        //変数に変数を代入
        float height1 = 160.5f;
        float height2;
        height2 = height1;
        Debug.Log(height2);


        //文字列の取り扱い
        string name = "名前";
        Debug.Log(name);


        //計算
        int answer;
        answer = 1 + 2;
        Debug.Log(answer);

        //その他の四則計算
        answer = 0;

        answer = 3 - 4;//減算
        Debug.Log(answer);

        answer = 5 * 6;//乗算
        Debug.Log(answer);

        answer = 8 / 4;//除算
        Debug.Log(answer);


        //変数同士の演算
        int n1 = 9, n2 = 9;
        answer = 0;

        answer = n1 + n2;
        Debug.Log(answer);


        //便利やで
        answer = 10;
        answer += 5;
        Debug.Log(answer);

        answer = 10;
        answer++;
        Debug.Log(answer);


        //文字列同士の連結
        string str1 = "ウェルトゥー";
        string str2 = "ようこそ";
        string message;

        message = str1 + str2;
        Debug.Log(message);


        //文字列と数値の連結
        string str = "おん？";
        int num = 123;

        message = str + num;
        Debug.Log(message);


        //if文の使用例
        int herbNum = 1;
        if (herbNum == 1) Debug.Log("ポン");


        //if-else文で条件分岐
        int HP = 180;

        if (HP <= 50) Debug.Log("逃亡");
        else if (HP >= 200) Debug.Log("攻撃");
        else Debug.Log("防御");


        ////変数のスコープ
        //int x = 1;
        //if (x == 1){
        //    int y = 2;
        //    Debug.Log(x);
        //    Debug.Log(y);
        //}
        //Debug.Log(y);


        //for 文で繰り返し
        for (int i = 0; i < 5; i++) Debug.Log(i);


        //特定の範囲だけを表示
        for (int i = 3; i <= 5; i++) Debug.Log(i);


        //カウントダウンしてみる
        for (int i = 3; i >= 0; i--) Debug.Log(i);


        //数の合計を求める
        int sum = 0;
        for (int i = 1; i <= 10; i++) sum += i;
        Debug.Log(sum);


        //おわり

    }

    // Update is called once per frame
    void Update () {
		
	}
}
