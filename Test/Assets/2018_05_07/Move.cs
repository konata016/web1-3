using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Vectorクラスの使い方
        Vector2 PL_pos = new Vector2(3.0f, 4.0f);
        PL_pos.x += 8.0f;
        PL_pos.y += 5.0f;
        Debug.Log(PL_pos);


        //ベクトルの減算
        Vector2 Start_pos = new Vector2(2.0f, 1.0f);
        Vector2 End_pos = new Vector2(8.0f, 5.0f);
        Vector2 dir = End_pos - Start_pos;
        Debug.Log(dir);

        float len = dir.magnitude;
        Debug.Log(len);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
