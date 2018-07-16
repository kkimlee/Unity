using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Running : MonoBehaviour {

		public Transform explode;
		public GameObject light;
		GameObject director;
		Rigidbody2D rigid2d;
		float jumpForce = 680.0f;
		float walkForce = 20.0f;
		float maxWalkSpeed = 2.0f;
		float jumping = 0;
	
	// Use this for initialization
	void Start () {
		this.rigid2d = GetComponent<Rigidbody2D>();
		this.director = GameObject.Find("GameDirector");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow) && jumping == 0)
		{
			jumping = 1;
			this.rigid2d.AddForce(transform.up * this.jumpForce);
		}

		int key = 0;
		if(Input.GetKey(KeyCode.RightArrow)) key = 1;
		if(Input.GetKey(KeyCode.LeftArrow)) key = -1;

		float speedx = Mathf.Abs(this.rigid2d.velocity.x);

		if(speedx < this.maxWalkSpeed)
		{
			this.rigid2d.AddForce(transform.right * key * this.walkForce);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "star")
			{
				GameObject lightObj = Instantiate(light,other.gameObject.transform.position,Quaternion.identity);
				this.director.GetComponent<GameDirector>().GetStar();
				Destroy(other.gameObject);
				Destroy(lightObj,2.0f);
			}
	}

	void OnCollisionEnter2D(Collision2D other)
	{

		if(other.gameObject.tag == "ball")
		{
			jumping = 0;
			return ;
		}
		
		if(other.gameObject.tag == "bomb")
		{
			Instantiate(explode,other.gameObject.transform.position,Quaternion.identity);
			Destroy(other.gameObject);
		}
		Destroy(gameObject);
	}
}
