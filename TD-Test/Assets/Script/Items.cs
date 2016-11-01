using UnityEngine;
using System.Collections;

public class Items : MonoBehaviour 
{
	[SerializeField]
	private Transform m_Object;

	private bool m_Pausing;

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{

	}

	void OnCollisionEnter(Collision collision)
	{
		m_Pausing = GameObject.Find("Player").GetComponent<GameOver>().pausing;

		if (m_Pausing == false) 
		{
			if (collision.transform.tag == "Floor") {
				//Destroy (gameObject);
				transform.position = new Vector3 (m_Object.position.x, m_Object.position.y, m_Object.position.z);
			}

			if (collision.transform.tag == "Player" && transform.tag == "Buff") {
				//Destroy (gameObject);
				transform.position = new Vector3 (m_Object.position.x, m_Object.position.y, m_Object.position.z);
			}
		}
	}

}
