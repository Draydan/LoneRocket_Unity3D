using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public static GUIText debugText;
	public string debugTextValue;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public static void Trace(string msg){
		debugText.text = msg;
	}

}
