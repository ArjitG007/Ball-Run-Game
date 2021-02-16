using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoins : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 turncoins;

    // Update is called once per frame
    void Update()
    {
        turncoins = new Vector3(45, 0, 0);
        transform.Rotate(turncoins *Time.deltaTime);
        
    }
}
