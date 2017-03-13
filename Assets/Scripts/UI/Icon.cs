using UnityEngine;
using System.Collections;

public class Icon : MonoBehaviour {

	public Camera m_Camera;

	void Update()
	{
		if(m_Camera.orthographic)
			transform.LookAt(transform.position - m_Camera.transform.forward, m_Camera.transform.up);
		else   
			transform.LookAt(m_Camera.transform.position, m_Camera.transform.up);
	}
}
