using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
	public GameObject BounceEffect;


	void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.collider.tag == "Ground")
		{
			FindAnyObjectByType<Audio>().Play("BallSound");
		}
	}


	//private void OnTriggerEnter2D(Collider2D collision)
	//{
	//	if(collision.gameObject.CompareTag("Ground"))
	//	{
	//		FindAnyObjectByType<Audio>().Play("BallSound");
	//	}
	//}
}
