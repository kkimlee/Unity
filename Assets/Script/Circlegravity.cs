using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circlegravity : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public List<GameObject> objects;
    public GameObject planet;
 
    public float gravitationalPull;
 
    void FixedUpdate() {
        foreach (GameObject o in objects) {
            if(o.GetComponent<Rigidbody2D>()){
                o.GetComponent<Rigidbody2D>().AddForce((planet.transform.position - o.transform.position).normalized * gravitationalPull);
            }
        }
      
		
    }
}
