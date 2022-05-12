using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    //public AudioSource Scream;
    public GameObject ThePlayer;
    public GameObject JumpCam;
    public GameObject FlashImg;

    public float jumpScareDistance = 2.0f;
    public GameObject miniMapDeactivate;
  




    private void Update()
    {
        float dist = Vector3.Distance(transform.position, ThePlayer.transform.position);

        if (jumpScareDistance > dist)
        {

            //Scream.Play();
            JumpCam.SetActive(true);
            ThePlayer.SetActive(false);
            FlashImg.SetActive(true);
            StartCoroutine(EndJump());
            miniMapDeactivate.SetActive(false);
            
        }
        



        IEnumerator EndJump()
        {
            yield return new WaitForSeconds(2.03f);
            ThePlayer.SetActive(true);
            JumpCam.SetActive(false);
            FlashImg.SetActive(false);

        }
    }
}
