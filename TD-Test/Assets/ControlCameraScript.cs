using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlCameraScript : MonoBehaviour 
{
    [SerializeField]
    private GameObject m_Camera;



	void Start () 
    {
	}
	
	void Update () 
    {
//#if UNITY_EDITOR_MAC

        float x = 10 * Input.GetAxis("Mouse X"); 
        float y = -10 * Input.GetAxis("Mouse Y");

        m_Camera.transform.Rotate(y, x, 0);

        float z = m_Camera.transform.eulerAngles.z;

        m_Camera.transform.Rotate(0, 0, -z);
//#endif
	}
}
