
using UnityEngine;
using System.Collections;

public class MakeItems : MonoBehaviour 
{
	[SerializeField]
	private Transform m_Player;

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector3 (transform.position.x, m_Player.position.y + 29, transform.position.z);
	}
}
