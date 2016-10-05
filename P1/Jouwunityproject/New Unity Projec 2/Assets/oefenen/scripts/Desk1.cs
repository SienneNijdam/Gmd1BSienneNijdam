using UnityEngine;
using System.Collections;


public class Desk1 : MonoBehaviour {
	public int a;
	public bool b;
	
	// Update is called once per frame
	void Update () {
		if (a < 100) {
			a = a + 1;

			if (a == 100) {
				print ("klaar");
				b = true; 
			}

		}
				
	}
}
