using UnityEngine;

using System.Collections;


public class ScoreKeeper : MonoBehaviour {

    // Use this for initialization
    public int score = 0;

void Start () {
	
	}
	
	
// Update is called once per frame
	
void Update () {
	
	}

public void IncrementScore(int amount)
    {
        score += amount;
        print("You Scored. Your current score is " + score);       
    }
}
