using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBomb : MonoBehaviour {

	public GameObject bomb;
	public GameObject star;

	int span;
	float delta;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		delta += Time.deltaTime;
		if(delta > span)
		{
			delta = 0;
			span = Random.Range(3,6);
			int dice = Random.Range(1,6);
			span += dice;
			if(span > 8)
			{
				GameObject starobj = Instantiate(star, gameObject.transform.position, gameObject.transform.rotation);
			}
			else
			{
				GameObject obj = Instantiate(bomb,gameObject.transform.position,gameObject.transform.rotation);
			}
		}
	}
}
