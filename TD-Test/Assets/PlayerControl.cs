﻿using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{


	[SerializeField]
	private Transform m_Player;

	private float m_X = 4.0f;
	private float m_Y = 1.0f;
	private float m_Z = 4.0f;

	void Start ()
	{

		//if(transform.position.x==)
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.LeftArrow))
		{
			Debug.Log ("左");
			if (m_Player.position.x == -12) 
			{
				if (m_Player.position.z <= 4) 
				{
					m_Player.position = new Vector3 (m_Player.position.x, m_Player.position.y, m_Player.position.z + m_Z);
				}
			}
			else
			{
				if (m_Player.position.x >= -12)
				{
					m_Player.position = new Vector3 (m_Player.position.x - m_X, m_Player.position.y, m_Player.position.z);
				}
			}
		}

		if (Input.GetKeyDown (KeyCode.RightArrow))
		{
			Debug.Log ("右");
			if (m_Player.position.z == -12) 
			{
				if (m_Player.position.x <= 4) 
				{
					m_Player.position = new Vector3 (m_Player.position.x + m_X, m_Player.position.y, m_Player.position.z);
				}
			}
			else
			{
				if (m_Player.position.z >= -12)
				{
					m_Player.position = new Vector3 (m_Player.position.x, m_Player.position.y, m_Player.position.z - m_Z);
				}
			}
		}

		if (Input.GetKeyDown (KeyCode.UpArrow))
		{
			Debug.Log ("上");

			m_Player.position = new Vector3 (m_Player.position.x, m_Player.position.y + m_Y, m_Player.position.z);
		}
	}
}