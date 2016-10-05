using UnityEngine;
using System.Collections;
using UnityEngine.UI;  

public class Buttontest2 : MonoBehaviour {
	public Button knop;
	public Text tekstUI;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Geklikt()
	{
		tekstUI.text = "yo"; 
	}

}
