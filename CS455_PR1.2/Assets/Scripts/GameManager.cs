using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive( true );
    }

    public void EndGame()
    {
        if( !gameHasEnded ) {
	    gameHasEnded = true;
	    Invoke("Restart", restartDelay);
	}
    }

    void Start(){
        Vector3[] poss = new Vector3[]{ new Vector3(4.5f, 1, -12.45f),
                                        new Vector3(-7, 1, -15),
                                        new Vector3(-3.2f, 1, -8.1f),
                                        new Vector3(-10.3f, 1, -5.3f),
                                        new Vector3(-2.45f, 1, 10.8f),
                                        new Vector3(7.7f, 1, 4.4f),
                                        new Vector3(4.5f, 1, 16.6f) };
        GameObject.Find("Moving_Obstacle").transform.position = poss[ (int)Random.Range(0, poss.Length) ];
    }
    
    void Restart ()
    {
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
    }
}
