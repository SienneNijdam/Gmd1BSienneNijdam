using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Buttontest : MonoBehaviour {
	public Button knop;
	public Text tekst;





	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Geklikt ()
	{
		tekst.text = "geklikt";
	}
}
