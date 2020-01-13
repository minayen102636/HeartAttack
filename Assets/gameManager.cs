using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameManager : MonoBehaviour {
    public Text scoreText;
    int score;
// Use this for initialization
void Start () {
        score = 0;
}

// Update is called once per frame
void Update () {

}
    public void addScore(int n){
        score += n;
        scoreText.text = "score: " + score;
    }
}
