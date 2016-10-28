using UnityEngine;
using System.Collections;

public class FloorMove : MonoBehaviour 
{
	[SerializeField]
	private Transform m_Floor;

	[SerializeField]
	private float m_Speed;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		m_Floor.position = new Vector3 (m_Floor.position.x, m_Floor.position.y + m_Speed, m_Floor.position.z);
	}
}
