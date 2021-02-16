using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GroundRestart : MonoBehaviour
{  void OnTriggerEnter()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
