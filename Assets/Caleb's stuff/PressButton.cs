using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressButton : MonoBehaviour
{
    [Header("bool")]
    public bool canDestroyProjectile0;
    public bool canDestroyProjectile1;
    public bool canDestroyProjectile2;
    public bool canDestroyProjectile3;
    public bool canDestroyProjectile4;
    public bool canDestroyProjectile5;
    public bool canDestroyProjectile6;
    public bool canDestroyProjectile7;
    public bool canDestroyProjectile8;
    public bool canDestroyProjectile9;
    
    [Header("point counter")]
    public int valueThatStartsMovement;
    public int progressBarIncrease;

    [Header("other scripts")]
    public ProgressBar progressBarScript;
    public movementOfBox[] movementOfBoxScript;
    public FailureBar failureBarScript;

    [Header("sprite changes")]
    public SpriteRenderer boxSpriteRend;
    public Sprite[] boxSprites;

    [Header("sound effects")]
    public AudioSource[] soundEffects;

    [Header("Remote Sprite")]
    public GameObject[] remoteSprite;

    void Start()
    {
        //starts will all bools as false
        canDestroyProjectile0 = false;
        canDestroyProjectile1 = false;
        canDestroyProjectile2 = false;
        canDestroyProjectile3 = false;
        canDestroyProjectile4 = false;
        canDestroyProjectile5 = false;
        canDestroyProjectile6 = false;
        canDestroyProjectile7 = false;
        canDestroyProjectile8 = false;
        canDestroyProjectile9 = false;

        //at the start the box is white
        boxSpriteRend.sprite = boxSprites[0];

        //The progress bar has a value of ZERO
        progressBarScript.progressBarSlider.value = 0;

        //movement is disabled
        movementOfBoxScript[0].enabled = false;
        movementOfBoxScript[1].enabled = false;

        //remote sprites
        remoteSprite[0].SetActive(true);
        remoteSprite[1].SetActive(false);
        remoteSprite[2].SetActive(false);

        //progress bar increase when button is pressed correctly
        progressBarIncrease = 5;

        //The value when the BOX starts moving
        //valueThatStartsMovement = 20;


        //
        // 8HRS! to get to where I AM!!
        //
    }


    void Update()
    {
        #region key 0:
        //Can destroy if it is in range
        if (canDestroyProjectile0 && Input.GetKey(KeyCode.Keypad0))
        {
            Destroy(GameObject.FindWithTag("0"));

            //Add TWO to the value
            progressBarScript.progressBarSlider.value += progressBarIncrease;

            soundEffects[0].Play();
            remoteSprite[0].SetActive(false);
            remoteSprite[1].SetActive(true);
            remoteSprite[2].SetActive(false);

            Debug.Log("Destroy Projectile!");
            Debug.Log("Player has made " + progressBarScript.progressBarSlider.value + "% progress");
        }
        #endregion

        #region key 1:
        if (canDestroyProjectile1 && Input.GetKey(KeyCode.Keypad1))
        {
            Destroy(GameObject.FindWithTag("1"));

            //Add TWO to the value
            progressBarScript.progressBarSlider.value += progressBarIncrease;

            soundEffects[0].Play();
            remoteSprite[0].SetActive(false);
            remoteSprite[1].SetActive(true);
            remoteSprite[2].SetActive(false);

            Debug.Log("Destroy Projectile!");
            Debug.Log("Player has made " + progressBarScript.progressBarSlider.value + "% progress");
        }
        #endregion

        #region key 2:
        if (canDestroyProjectile2 && Input.GetKey(KeyCode.Keypad2))
        {
            Destroy(GameObject.FindWithTag("2"));

            //Add TWO to the value
            progressBarScript.progressBarSlider.value += progressBarIncrease;

            soundEffects[0].Play();
            remoteSprite[0].SetActive(false);
            remoteSprite[1].SetActive(true);
            remoteSprite[2].SetActive(false);

            Debug.Log("Destroy Projectile!");
            Debug.Log("Player has made " + progressBarScript.progressBarSlider.value + "% progress");
        }
        #endregion

        #region key 3:
        if (canDestroyProjectile3 && Input.GetKey(KeyCode.Keypad3))
        {
            Destroy(GameObject.FindWithTag("3"));

            //Add TWO to the value
            progressBarScript.progressBarSlider.value += progressBarIncrease;

            soundEffects[0].Play();
            remoteSprite[0].SetActive(false);
            remoteSprite[1].SetActive(true);
            remoteSprite[2].SetActive(false);

            Debug.Log("Destroy Projectile!");
            Debug.Log("Player has made " + progressBarScript.progressBarSlider.value + "% progress");
        }
        #endregion

        #region key 4:
        if (canDestroyProjectile4 && Input.GetKey(KeyCode.Keypad4))
        {
            Destroy(GameObject.FindWithTag("4"));

            //Add TWO to the value
            progressBarScript.progressBarSlider.value += progressBarIncrease;

            soundEffects[0].Play();
            remoteSprite[0].SetActive(false);
            remoteSprite[1].SetActive(true);
            remoteSprite[2].SetActive(false);

            Debug.Log("Destroy Projectile!");
            Debug.Log("Player has made " + progressBarScript.progressBarSlider.value + "% progress");
        }
        #endregion

        #region key 5:
        if (canDestroyProjectile5 && Input.GetKey(KeyCode.Keypad5))
        {
            Destroy(GameObject.FindWithTag("5"));

            //Add TWO to the value
            progressBarScript.progressBarSlider.value += progressBarIncrease;

            soundEffects[0].Play();
            remoteSprite[0].SetActive(false);
            remoteSprite[1].SetActive(true);
            remoteSprite[2].SetActive(false);

            Debug.Log("Destroy Projectile!");
            Debug.Log("Player has made " + progressBarScript.progressBarSlider.value + "% progress");
        }
        #endregion

        #region key 6:
        if (canDestroyProjectile6 && Input.GetKey(KeyCode.Keypad6))
        {
            Destroy(GameObject.FindWithTag("6"));

            //Add TWO to the value
            progressBarScript.progressBarSlider.value += progressBarIncrease;

            soundEffects[0].Play();
            remoteSprite[0].SetActive(false);
            remoteSprite[1].SetActive(true);
            remoteSprite[2].SetActive(false);

            Debug.Log("Destroy Projectile!");
            Debug.Log("Player has made " + progressBarScript.progressBarSlider.value + "% progress");
        }
        #endregion

        #region key 7:
        if (canDestroyProjectile7 && Input.GetKey(KeyCode.Keypad7))
        {
            Destroy(GameObject.FindWithTag("7"));

            //Add TWO to the value
            progressBarScript.progressBarSlider.value += progressBarIncrease;

            soundEffects[0].Play();
            remoteSprite[0].SetActive(false);
            remoteSprite[1].SetActive(true);
            remoteSprite[2].SetActive(false);

            Debug.Log("Destroy Projectile!");
            Debug.Log("Player has made " + progressBarScript.progressBarSlider.value + "% progress");
        }
        #endregion

        #region key 8:
        if (canDestroyProjectile8 && Input.GetKey(KeyCode.Keypad8))
        {
            Destroy(GameObject.FindWithTag("8"));

            //Add TWO to the value
            progressBarScript.progressBarSlider.value += progressBarIncrease;

            soundEffects[0].Play();
            remoteSprite[0].SetActive(false);
            remoteSprite[1].SetActive(true);
            remoteSprite[2].SetActive(false);

            Debug.Log("Destroy Projectile!");
            Debug.Log("Player has made " + progressBarScript.progressBarSlider.value + "% progress");
        }
        #endregion

        #region key 9:
        if (canDestroyProjectile9 && Input.GetKey(KeyCode.Keypad9))
        {
            Destroy(GameObject.FindWithTag("9"));

            //Add TWO to the value
            progressBarScript.progressBarSlider.value += progressBarIncrease;

            soundEffects[0].Play();
            remoteSprite[0].SetActive(false);
            remoteSprite[1].SetActive(true);
            remoteSprite[2].SetActive(false);

            Debug.Log("Destroy Projectile!");
            Debug.Log("Player has made " + progressBarScript.progressBarSlider.value + "% progress");
        }
        #endregion

        //If it is bigger than a certain amount, the movement starts
        if (progressBarScript.progressBarSlider.value > 20)
        {
            movementOfBoxScript[0].enabled = true;
        }
        
        if (progressBarScript.progressBarSlider.value > 50)
        {
            movementOfBoxScript[1].enabled = true;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        #region tags:
        if (collision.gameObject.CompareTag("0")) 
        {
            canDestroyProjectile0 = true;
            WhiteToGreen();

            Debug.Log("object in block");
        }

        if (collision.gameObject.CompareTag("1")) 
        {
            canDestroyProjectile1 = true;
            WhiteToGreen();

            Debug.Log("object in block");
        }

        if (collision.gameObject.CompareTag("2")) 
        {
            canDestroyProjectile2 = true;
            WhiteToGreen();

            Debug.Log("object in block");
        }

        if (collision.gameObject.CompareTag("3")) 
        {
            canDestroyProjectile3 = true;
            WhiteToGreen();

            Debug.Log("object in block");
        }

        if (collision.gameObject.CompareTag("4")) 
        {
            canDestroyProjectile4 = true;
            WhiteToGreen();

            Debug.Log("object in block");
        }

        if (collision.gameObject.CompareTag("5")) 
        {
            canDestroyProjectile5 = true;
            WhiteToGreen();

            Debug.Log("object in block");
        }

        if (collision.gameObject.CompareTag("6")) 
        {
            canDestroyProjectile6 = true;
            WhiteToGreen();

            Debug.Log("object in block");
        }

        if (collision.gameObject.CompareTag("7")) 
        {
            canDestroyProjectile7 = true;
            WhiteToGreen();

            Debug.Log("object in block");
        }

        if (collision.gameObject.CompareTag("8")) 
        {
            canDestroyProjectile8 = true;
            WhiteToGreen();

            Debug.Log("object in block");
        }

        if (collision.gameObject.CompareTag("9")) 
        {
            canDestroyProjectile9 = true;
            WhiteToGreen();

            Debug.Log("object in block");
        }
        #endregion
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        #region tags:
        if (collision.gameObject.CompareTag("0"))
        {
            canDestroyProjectile0 = false;
            GreenToWhite();

            remoteSprite[0].SetActive(true);
            remoteSprite[1].SetActive(false);
            remoteSprite[2].SetActive(false);

            Debug.Log("object1 OUT OF block");
        }

        if (collision.gameObject.CompareTag("1"))
        {
            canDestroyProjectile1 = false;
            GreenToWhite();

            remoteSprite[0].SetActive(true);
            remoteSprite[1].SetActive(false);
            remoteSprite[2].SetActive(false);

            Debug.Log("object2 OUT OF block");
        }

        if (collision.gameObject.CompareTag("2"))
        {
            canDestroyProjectile2 = false;
            GreenToWhite();

            remoteSprite[0].SetActive(true);
            remoteSprite[1].SetActive(false);
            remoteSprite[2].SetActive(false);

            Debug.Log("object3 OUT OF block");
        }

        if (collision.gameObject.CompareTag("3"))
        {
            canDestroyProjectile3 = false;
            GreenToWhite();

            remoteSprite[0].SetActive(true);
            remoteSprite[1].SetActive(false);
            remoteSprite[2].SetActive(false);

            Debug.Log("object4 OUT OF block");
        }

        if (collision.gameObject.CompareTag("4"))
        {
            canDestroyProjectile4 = false;
            GreenToWhite();

            remoteSprite[0].SetActive(true);
            remoteSprite[1].SetActive(false);
            remoteSprite[2].SetActive(false);

            Debug.Log("object5 OUT OF block");
        }

        if (collision.gameObject.CompareTag("5"))
        {
            canDestroyProjectile5 = false;
            GreenToWhite();

            remoteSprite[0].SetActive(true);
            remoteSprite[1].SetActive(false);
            remoteSprite[2].SetActive(false);

            Debug.Log("object6 OUT OF block");
        }

        if (collision.gameObject.CompareTag("6"))
        {
            canDestroyProjectile6 = false;
            GreenToWhite();

            remoteSprite[0].SetActive(true);
            remoteSprite[1].SetActive(false);
            remoteSprite[2].SetActive(false);

            Debug.Log("object7 OUT OF block");
        }

        if (collision.gameObject.CompareTag("7"))
        {
            canDestroyProjectile7 = false;
            GreenToWhite();

            remoteSprite[0].SetActive(true);
            remoteSprite[1].SetActive(false);
            remoteSprite[2].SetActive(false);

            Debug.Log("object8 OUT OF block");
        }

        if (collision.gameObject.CompareTag("8"))
        {
            canDestroyProjectile8 = false;
            GreenToWhite();

            remoteSprite[0].SetActive(true);
            remoteSprite[1].SetActive(false);
            remoteSprite[2].SetActive(false);

            Debug.Log("object9 OUT OF block");
        }

        if (collision.gameObject.CompareTag("9"))
        {
            canDestroyProjectile9 = false;
            GreenToWhite();

            remoteSprite[0].SetActive(true);
            remoteSprite[1].SetActive(false);
            remoteSprite[2].SetActive(false);

            Debug.Log("object10 OUT OF block");
        }
        #endregion
    }

    #region sprite changes:
    void WhiteToGreen()
    {
        boxSpriteRend.sprite = boxSprites[1];
    }

    void GreenToWhite()
    {
        boxSpriteRend.sprite = boxSprites[0];
    }
    #endregion
}
