using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCircle : MonoBehaviour {

	public float speed;
	public float rotSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate(speed * Time.deltaTime,0 ,0,Space.World);
		gameObject.transform.Rotate(new Vector3(0,0,rotSpeed * Time.deltaTime));

	}
}
