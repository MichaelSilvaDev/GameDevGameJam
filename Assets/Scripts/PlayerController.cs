using UnityEngine;
using System.Collections;
using UnityEditor;

public class PlayerController : MonoBehaviour
{

	[SerializeField] float speed = 10.0F;
	[SerializeField] float rotateSpeed = 10.0f;


	void Start()
	{
		

	}

	void Update()
	{
		
		PlayerInput();


	}

	

	private void PlayerInput()
	{
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(Vector3.forward * speed * Time.deltaTime * -1);
		}
	}

	
}