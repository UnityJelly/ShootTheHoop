using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {

	    // Use this for initialization
	
    void Start () {

	}
	
	
        // Update is called once per frame
	

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadNextScene();
        }
/*        else if(ScoreKeeper.score > 50)
        {
            LoadGameOverScene();
        }*/
    }

    private static void LoadNextScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex + 1);
    }

/*    private static void LoadGameOverScene()
    {
        SceneManager.LoadScene("03_GameOver");
        return;
    }*/

}
