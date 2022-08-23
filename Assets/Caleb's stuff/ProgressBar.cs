using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.
using UnityEngine.SceneManagement;

public class ProgressBar : MonoBehaviour
{
    [Header("slider")]
    public Slider progressBarSlider;

    public ObjectLauncher[] objectLauncherScript;
    public GameObject DarkerShadeNext;

    public GameObject InstrcutionsPt2;
    public GameObject destroyArea;

    void Start()
    {
        //value is at zero AT THE START
        progressBarSlider.value = 0;

        DarkerShadeNext.SetActive(false);
        InstrcutionsPt2.SetActive(false);
    }


    void Update()
    {
        //If the value reaches 100.... increase the box speed
        if(progressBarSlider.value > 30)
        {
            objectLauncherScript[0].projectileSpeed = 3;
            objectLauncherScript[1].projectileSpeed = 3;

            Debug.Log("The projectile speed is " + objectLauncherScript[0].projectileSpeed);
            Debug.Log("The projectile speed is " + objectLauncherScript[1].projectileSpeed);
        }

        //If the value reaches 100.... increase the box speed
        if (progressBarSlider.value > 60)
        {
            objectLauncherScript[0].projectileSpeed = 4;
            objectLauncherScript[1].projectileSpeed = 4;
        }

        if(progressBarSlider.value == 110)
        {
            //deactivate launcher scripts game then reload scene
            DarkerShadeNext.SetActive(true);
            destroyArea.SetActive(false);

            StartCoroutine(reloadScene());
        }

    }

    IEnumerator reloadScene()
    {
        yield return new WaitForSeconds(1.5f);

        InstrcutionsPt2.SetActive(true);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
