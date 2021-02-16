using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endscript : MonoBehaviour
{
    // Start is called before the first frame update
   public void restartgame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void exitgame()
    {
        Debug.Log("Exit button pressed");
        Application.Quit();
    }
}
