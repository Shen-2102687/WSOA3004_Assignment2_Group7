using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject[] puzzleBlocks;
    bool canHover = true;
    bool canSwap = false;
    bool canHover2 = false;


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
        //Debug.Log("Clicked image");
        Debug.Log("Clicked puzzblock:" + puzzleBlock.gameObject.name);
        

        int index = System.Array.IndexOf(puzzleBlocks, puzzleBlock);
        Debug.Log(index);

        if (canHover)
        {
            switch (index)
            {
                case 0:
                    //canHover = false;
                    canHover = false;
                    canHover2 = true;
                    canSwap = true;
                    changeToWhite();
                    puzzleBlocks[1].gameObject.GetComponent<Image>().color = Color.green;
                    puzzleBlocks[3].gameObject.GetComponent<Image>().color = Color.green;
                    puzzleBlocks[4].gameObject.GetComponent<Image>().color = Color.green;

                    break;
                case 1:
                    canHover = false;
                    canHover2 = true;
                    canSwap = true;
                    changeToWhite();
                    puzzleBlocks[0].gameObject.GetComponent<Image>().color = Color.green;
                    puzzleBlocks[2].gameObject.GetComponent<Image>().color = Color.green;
                    puzzleBlocks[4].gameObject.GetComponent<Image>().color = Color.green;

                    break;
                case 2:
                    canHover = false;
                    canHover2 = true;
                    canSwap = true;
                    changeToWhite();
                    puzzleBlocks[1].gameObject.GetComponent<Image>().color = Color.green;
                    puzzleBlocks[4].gameObject.GetComponent<Image>().color = Color.green;
                    puzzleBlocks[5].gameObject.GetComponent<Image>().color = Color.green;
                    break;
                case 3:
                    canHover = false;
                    canHover2 = true;
                    canSwap = true;
                    changeToWhite();
                    puzzleBlocks[0].gameObject.GetComponent<Image>().color = Color.green;
                    puzzleBlocks[4].gameObject.GetComponent<Image>().color = Color.green;
                    puzzleBlocks[6].gameObject.GetComponent<Image>().color = Color.green;
                    break;
                case 4:
                    canHover = false;
                    canHover2 = true;
                    canSwap = true;
                    changeToWhite();
                    puzzleBlocks[0].gameObject.GetComponent<Image>().color = Color.green;
                    puzzleBlocks[1].gameObject.GetComponent<Image>().color = Color.green;
                    puzzleBlocks[2].gameObject.GetComponent<Image>().color = Color.green;
                    puzzleBlocks[3].gameObject.GetComponent<Image>().color = Color.green;
                    puzzleBlocks[5].gameObject.GetComponent<Image>().color = Color.green;
                    puzzleBlocks[6].gameObject.GetComponent<Image>().color = Color.green;
                    break;
                case 5:
                    canHover = false;
                    canHover2 = true;
                    canSwap = true;
                    changeToWhite();
                    puzzleBlocks[2].gameObject.GetComponent<Image>().color = Color.green;
                    puzzleBlocks[4].gameObject.GetComponent<Image>().color = Color.green;
                    puzzleBlocks[6].gameObject.GetComponent<Image>().color = Color.green;
                    break;
                case 6:
                    canHover = false;
                    canHover2 = true;
                    canSwap = true;
                    changeToWhite();
                    puzzleBlocks[3].gameObject.GetComponent<Image>().color = Color.green;
                    puzzleBlocks[4].gameObject.GetComponent<Image>().color = Color.green;
                    puzzleBlocks[5].gameObject.GetComponent<Image>().color = Color.green;
                    break;
            }
        }else if (canSwap)
        {
            if (puzzleBlocks[index].gameObject.GetComponent<Image>().color == /*Color.green*/ new Color(62f / 255f, 110f / 255f, 49f / 255f))
            {
                Debug.Log("Swap Now");
                canSwap = false;
                canHover2 = false;
                canHover = true;
                changeToWhite();
            }
            else
            {
                Debug.Log("No swap");
                canSwap = false;
                canHover2 = false;
                canHover = true;
                changeToWhite();
            }
                
        }

    }

    public void onHoverEnter(GameObject puzzleBlock)
    {
        if (canHover)
        {
            puzzleBlock.gameObject.GetComponent<Image>().color = Color.grey;
        }

        if (canHover2)
        {
            if (puzzleBlock.gameObject.GetComponent<Image>().color == Color.green)
            {
                puzzleBlock.gameObject.GetComponent<Image>().color = new Color(62f/255f, 110f/255f, 49f/255f);
            }
            if (puzzleBlock.gameObject.GetComponent<Image>().color == Color.white)
            {
                puzzleBlock.gameObject.GetComponent<Image>().color = Color.grey;
            }
        }
        
    }

    public void onHoverExit(GameObject puzzleBlock)
    {
        if (canHover)
        {
            puzzleBlock.gameObject.GetComponent<Image>().color = Color.white;
        }

        if (canHover2)
        {
            if (puzzleBlock.gameObject.GetComponent<Image>().color == new Color(62f / 255f, 110f / 255f, 49f / 255f))
            {
                puzzleBlock.gameObject.GetComponent<Image>().color = Color.green;
            }
            if (puzzleBlock.gameObject.GetComponent<Image>().color == Color.grey)
            {
                puzzleBlock.gameObject.GetComponent<Image>().color = Color.white;
            }
        }
        
    }

    public void changeToWhite()
    {
        foreach (GameObject puzzleBlock in puzzleBlocks)
        {
            puzzleBlock.gameObject.GetComponent<Image>().color = Color.white;
        }
    }

}
