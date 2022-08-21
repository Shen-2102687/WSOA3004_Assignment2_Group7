using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject[] puzzleBlocks;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickFunction(GameObject puzzleBlock)
    {
        Debug.Log("Clicked image");
        Debug.Log("Clicked puzzblock:" + puzzleBlock.gameObject.name);
    }

    public void onHoverEnter(GameObject puzzleBlock)
    {
        puzzleBlock.gameObject.GetComponent<Image>().color = Color.grey;
    }

    public void onHoverExit(GameObject puzzleBlock)
    {
        puzzleBlock.gameObject.GetComponent<Image>().color = Color.white;
    }

}
