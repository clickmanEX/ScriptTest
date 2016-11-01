using UnityEngine;
using System.Collections;

public class Test1 : MonoBehaviour {

	// Use this for initialization
	void Start () {

        int[] array = { 10, 5, 32, 40, 1 };

        for(int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        for(int j = 4; j >= 0; j--)
        {
            Debug.Log(array[j]);
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
