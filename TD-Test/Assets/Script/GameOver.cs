using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver : MonoBehaviour 
{
	[SerializeField]
	private Text m_GameOver;


	void OnCollisionEnter(Collision collision)
	{
		if (collision.transform.tag == "Floor")
		{
			Debug.Log ("GameOver");
			m_GameOver.text = "GameOver";
		}
	}


	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
