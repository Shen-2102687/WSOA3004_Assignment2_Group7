using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyArea : MonoBehaviour
{
    [Header("other scripts")]
    public FailureBar failureBarScript;
    public PressButton[] pressButtonScript;

    [Header("failure punishment")]
    public int failurePunishment;

    [Header("sound effects")]
    public AudioSource failSoundEffects;

    private void Start()
    {
        failurePunishment = 25;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        #region tag 0
        //if it collides with one of the following tags
        if (collision.gameObject.CompareTag("0")) 
        {
            Destroy(GameObject.FindWithTag("0"));

            //Increase failure bar ... can ONLY miss 5
            failureBarScript.failureBarSlider.value += failurePunishment;

            failSoundEffects.Play();

            #region remote off
            pressButtonScript[0].remoteSprite[0].SetActive(false);
            pressButtonScript[0].remoteSprite[1].SetActive(false);
            pressButtonScript[0].remoteSprite[2].SetActive(true);


            pressButtonScript[1].remoteSprite[0].SetActive(false);
            pressButtonScript[1].remoteSprite[1].SetActive(false);
            pressButtonScript[1].remoteSprite[2].SetActive(true);
            #endregion

            Debug.Log("Lose point!");
        }
        #endregion

        #region tag 1
        //if it collides with one of the following tags
        if (collision.gameObject.CompareTag("1"))
        {
            Destroy(GameObject.FindWithTag("1"));

            //Increase failure bar ... can ONLY miss 5
            failureBarScript.failureBarSlider.value += failurePunishment;

            failSoundEffects.Play();

            #region remote off
            pressButtonScript[0].remoteSprite[0].SetActive(false);
            pressButtonScript[0].remoteSprite[1].SetActive(false);
            pressButtonScript[0].remoteSprite[2].SetActive(true);


            pressButtonScript[1].remoteSprite[0].SetActive(false);
            pressButtonScript[1].remoteSprite[1].SetActive(false);
            pressButtonScript[1].remoteSprite[2].SetActive(true);
            #endregion


            Debug.Log("Lose point!");
        }
        #endregion

        #region tag 2
        //if it collides with one of the following tags
        if (collision.gameObject.CompareTag("2"))
        {
            Destroy(GameObject.FindWithTag("2"));

            //Increase failure bar ... can ONLY miss 5
            failureBarScript.failureBarSlider.value += failurePunishment;

            failSoundEffects.Play();

            #region remote off
            pressButtonScript[0].remoteSprite[0].SetActive(false);
            pressButtonScript[0].remoteSprite[1].SetActive(false);
            pressButtonScript[0].remoteSprite[2].SetActive(true);


            pressButtonScript[1].remoteSprite[0].SetActive(false);
            pressButtonScript[1].remoteSprite[1].SetActive(false);
            pressButtonScript[1].remoteSprite[2].SetActive(true);
            #endregion


            Debug.Log("Lose point!");
        }
        #endregion

        #region tag 3
        //if it collides with one of the following tags
        if (collision.gameObject.CompareTag("3"))
        {
            Destroy(GameObject.FindWithTag("3"));

            //Increase failure bar ... can ONLY miss 5
            failureBarScript.failureBarSlider.value += failurePunishment;

            failSoundEffects.Play();

            #region remote off
            pressButtonScript[0].remoteSprite[0].SetActive(false);
            pressButtonScript[0].remoteSprite[1].SetActive(false);
            pressButtonScript[0].remoteSprite[2].SetActive(true);


            pressButtonScript[1].remoteSprite[0].SetActive(false);
            pressButtonScript[1].remoteSprite[1].SetActive(false);
            pressButtonScript[1].remoteSprite[2].SetActive(true);
            #endregion


            Debug.Log("Lose point!");
        }
        #endregion

        #region tag 4
        //if it collides with one of the following tags
        if (collision.gameObject.CompareTag("4"))
        {
            Destroy(GameObject.FindWithTag("4"));

            //Increase failure bar ... can ONLY miss 5
            failureBarScript.failureBarSlider.value += failurePunishment;

            failSoundEffects.Play();

            #region remote off
            pressButtonScript[0].remoteSprite[0].SetActive(false);
            pressButtonScript[0].remoteSprite[1].SetActive(false);
            pressButtonScript[0].remoteSprite[2].SetActive(true);


            pressButtonScript[1].remoteSprite[0].SetActive(false);
            pressButtonScript[1].remoteSprite[1].SetActive(false);
            pressButtonScript[1].remoteSprite[2].SetActive(true);
            #endregion


            Debug.Log("Lose point!");
        }
        #endregion

        #region tag 5
        //if it collides with one of the following tags
        if (collision.gameObject.CompareTag("5"))
        {
            Destroy(GameObject.FindWithTag("5"));

            //Increase failure bar ... can ONLY miss 5
            failureBarScript.failureBarSlider.value += failurePunishment;

            failSoundEffects.Play();

            Debug.Log("Lose point!");
        }
        #endregion

        #region tag 6
        //if it collides with one of the following tags
        if (collision.gameObject.CompareTag("6"))
        {
            Destroy(GameObject.FindWithTag("6"));

            //Increase failure bar ... can ONLY miss 5
            failureBarScript.failureBarSlider.value += failurePunishment;

            failSoundEffects.Play();

            #region remote off
            pressButtonScript[0].remoteSprite[0].SetActive(false);
            pressButtonScript[0].remoteSprite[1].SetActive(false);
            pressButtonScript[0].remoteSprite[2].SetActive(true);


            pressButtonScript[1].remoteSprite[0].SetActive(false);
            pressButtonScript[1].remoteSprite[1].SetActive(false);
            pressButtonScript[1].remoteSprite[2].SetActive(true);
            #endregion


            Debug.Log("Lose point!");
        }
        #endregion

        #region tag 7
        //if it collides with one of the following tags
        if (collision.gameObject.CompareTag("7"))
        {
            Destroy(GameObject.FindWithTag("7"));

            //Increase failure bar ... can ONLY miss 5
            failureBarScript.failureBarSlider.value += failurePunishment;

            failSoundEffects.Play();

            #region remote off
            pressButtonScript[0].remoteSprite[0].SetActive(false);
            pressButtonScript[0].remoteSprite[1].SetActive(false);
            pressButtonScript[0].remoteSprite[2].SetActive(true);


            pressButtonScript[1].remoteSprite[0].SetActive(false);
            pressButtonScript[1].remoteSprite[1].SetActive(false);
            pressButtonScript[1].remoteSprite[2].SetActive(true);
            #endregion


            Debug.Log("Lose point!");
        }
        #endregion

        #region tag 8
        //if it collides with one of the following tags
        if (collision.gameObject.CompareTag("8"))
        {
            Destroy(GameObject.FindWithTag("8"));

            //Increase failure bar ... can ONLY miss 5
            failureBarScript.failureBarSlider.value += failurePunishment;

            failSoundEffects.Play();

            #region remote off
            pressButtonScript[0].remoteSprite[0].SetActive(false);
            pressButtonScript[0].remoteSprite[1].SetActive(false);
            pressButtonScript[0].remoteSprite[2].SetActive(true);


            pressButtonScript[1].remoteSprite[0].SetActive(false);
            pressButtonScript[1].remoteSprite[1].SetActive(false);
            pressButtonScript[1].remoteSprite[2].SetActive(true);
            #endregion


            Debug.Log("Lose point!");
        }
        #endregion

        #region tag 9
        //if it collides with one of the following tags
        if (collision.gameObject.CompareTag("9"))
        {
            Destroy(GameObject.FindWithTag("9"));

            //Increase failure bar ... can ONLY miss 5
            failureBarScript.failureBarSlider.value += failurePunishment;

            failSoundEffects.Play();

            #region remote off
            pressButtonScript[0].remoteSprite[0].SetActive(false);
            pressButtonScript[0].remoteSprite[1].SetActive(false);
            pressButtonScript[0].remoteSprite[2].SetActive(true);


            pressButtonScript[1].remoteSprite[0].SetActive(false);
            pressButtonScript[1].remoteSprite[1].SetActive(false);
            pressButtonScript[1].remoteSprite[2].SetActive(true);
            #endregion


            Debug.Log("Lose point!");
        }
        #endregion
    }
}
