using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{
	public int mp = 53;

	public void Magic(){
		if (mp >= 5) {
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
		} else {
			Debug.Log ("MPが足りないため魔法攻撃をできません。");
		}
	}
}

public class Test : MonoBehaviour {
		

	// Use this for initialization
	void Start () {

		//配列の課題
		int[] array={2,4,6,8,10};
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}
		for (int i = array.Length-1; i >=0; i--) {
			Debug.Log (array [i]);
		}
		//発展課題
		Boss lastboss=new Boss();
		lastboss.Magic();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
