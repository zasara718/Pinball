using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	//スコアを０で初期化する
	int score = 0;
	//スコアを表示するテキスト
	private GameObject ScoreText;

	// Use this for initialization
	void Start () {
		//シーン中のScoreオブジェクトを取得
		this.ScoreText = GameObject.Find ("Score");
	}
	
	// Update is called once per frame
	void Update () {
		//ボールがタグ付けしたオブジェクトに触れた時scoreを加算する
		
	}

	void OnCollisionEnter (Collision other) {
		if (other.gameObject.tag == "SmallStarTag") {
			this.ScoreText.GetComponent<Text> ().text = "Score" + (this.score += 10);
		} else if (other.gameObject.tag == "LargeStarTag") {
			this.ScoreText.GetComponent<Text> ().text = "Score" + (this.score += 20);
		} else if (other.gameObject.tag == "SmallCloudTag") {
			this.ScoreText.GetComponent<Text> ().text = "Score" + (this.score += 15);
		} else if (other.gameObject.tag == "LargeCloudTag") {
			this.ScoreText.GetComponent<Text> ().text = "Score" + (this.score += 30);
		}
	}
}
