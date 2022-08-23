using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Required when Using UI elements

public class FailureBar : MonoBehaviour
{
    [Header("slider")]
    public Slider failureBarSlider;

    public GameObject DarkerShade;
    public GameObject InstrcutionsPt1;
    public GameObject destroyArea;

    void Start()
    {
        //value is at zero AT THE START
        failureBarSlider.value = 0;

        DarkerShade.SetActive(false);
        InstrcutionsPt1.SetActive(false);

        destroyArea.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(failureBarSlider.value == 100)
        {
            //deactivate launcher scripts game then reload scene
            destroyArea.SetActive(false);

            DarkerShade.SetActive(true);

            StartCoroutine(reloadScene());
        }
    }

    IEnumerator reloadScene()
    {
        yield return new WaitForSeconds(1.5f);
        InstrcutionsPt1.SetActive(true);
    }

    public void Yes()
    {
        SceneManager.LoadScene("Calebs Scene");
    }

    public void No()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
