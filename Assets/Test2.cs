using UnityEngine;
using System.Collections;

public class Sorcerer
{
    private int mp = 53;
    public void Magic()
    {
        if(this.mp > 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした！残りMPは" + mp + "。");
        }else
        {
            Debug.Log("MPが足りないため魔法は使えない。");
        }
    }
}

public class Test2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Sorcerer sorcerer = new Sorcerer();
        for(int i = 1;i <= 11; i++)
        {
            sorcerer.Magic();
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
