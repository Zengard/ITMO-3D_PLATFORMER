using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy : MonoBehaviour
{
	public Transform pos1;
	public Transform pos2;
	public float speed = 0.5f;

	public float flipPositionRight;
	public float flipPositionLeft;

	void Update()
	{
		transform.position = Vector3.Lerp(pos1.position, pos2.position, Mathf.PingPong(Time.time * speed, 1.0f));

		if(transform.position.x >= flipPositionRight)
        {
			transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        }

		if (transform.position.x <= flipPositionLeft)
		{
			transform.Rotate(0, 0, 0);
		}
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bullet")

        {
			other.gameObject.SetActive(false);
			gameObject.SetActive(false);
        }
    }
}
