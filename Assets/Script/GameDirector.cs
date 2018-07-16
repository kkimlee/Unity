using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour {

	GameObject scoreText;
	GameObject player;
	int score = 0;
	float nextScene = 3.0f;
	float delta = 0.0f;

	public void GetStar() {
		this.score += 100;
	}

	// Use this for initialization
	void Start () {
		this.scoreText = GameObject.Find("Score");
		this.player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Score : " + this.score.ToString());
		this.scoreText.GetComponent<Text>().text = ("Score : " + this.score.ToString());
		if(this.player == null)
		{
			delta += Time.deltaTime;
			if(delta > nextScene)
			{
				delta = 0.0f;
				SceneManager.LoadScene("GameOver");
			}
		}
	}
}
