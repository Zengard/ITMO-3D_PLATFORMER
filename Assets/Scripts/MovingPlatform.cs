using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
   public Transform pos1;
	public Transform pos2;
	public float speed;

	public float flipPositionRight;
	public float flipPositionLeft;

	void Update()
	{
		transform.position = Vector3.Lerp(pos1.position, pos2.position, Mathf.PingPong(Time.time * speed, 1.0f));

		
	}
}
