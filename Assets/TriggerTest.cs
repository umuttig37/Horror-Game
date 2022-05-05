using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{

    public GameObject GameWon;
    

    private void Start()
    {
        
    }

    public void LevelComplete()
    {
        GameWon.SetActive(true);

    }
    private void OnTriggerEnter(Collider other)
    {
        LevelComplete();
    }
}
