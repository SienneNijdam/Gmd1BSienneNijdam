using UnityEngine;
using System.Collections;

public class Test2 : MonoBehaviour {
	public int test; 
	public float test2; 
	bool test3; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		PlusEen ();
		PlusTwee ();
		test3 = true;
		print (test3);
		
	}
	void PlusEen () {
		test = test + 1;


	}
	void PlusTwee ()  {
		test2 = test2 + 0.1f; 
	}
}
