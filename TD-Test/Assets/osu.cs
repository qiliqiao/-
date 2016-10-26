using UnityEngine;
using System.Collections;


public class osu : MonoBehaviour 
{

	public int M_number;

	// Use this for initialization
	void Start () 
	{
		//Debug.Log (M_number);
	}
	
	// Update is called once per frame
	void Update () 
	{
		ClickTest ();
	}

	public void ClickTest()
	{
		Debug.Log (M_number);
	}
}
