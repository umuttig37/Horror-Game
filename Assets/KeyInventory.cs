using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace KeySystem 
{
    public class KeyInventory : MonoBehaviour
    {

        public bool hasRedKey = false;

        public GameObject haskey;
        public GameObject hasNoKey;

        private void Update()
        {           

            if(hasRedKey)
            {
                hasNoKey.SetActive(true);
                Debug.Log("has key");
            }
            else
            { 
                Debug.Log("has key");  
                
                haskey.SetActive(true);
            }
        }
    }
}