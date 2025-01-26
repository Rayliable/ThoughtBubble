using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UI;

public class captcha : MonoBehaviour
{

    int capNum;
    string answer;

    public GameObject select;

    [SerializeField] dreamScript Dream;

    public TextMeshProUGUI inputField;
    public Image capLose;
    public Image capWin;

    public SpriteRenderer cap_1;
    public SpriteRenderer cap_2;
    public SpriteRenderer cap_3;
    public SpriteRenderer cap_4;
    public SpriteRenderer cap_5;
    public SpriteRenderer cap_6;
    public string[,] firstKeyLetterMap;
    public string[,] keyLetterMap;
    public Transform cursor;
    public Transform[,] keyGrid;
    static int gridWidth = 3;
    static int gridHeight = 10;
    private int currentX = 0;
    private int currentY = 0;
    string typeInput = "";
    bool winning = false;
    void Start()
    {

        keyGrid = new Transform[10, 3];
        firstKeyLetterMap = new string[3, 10]{
            { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p" }, 
            { "a", "s", "d", "f", "g", "h", "j", "k", "l", "," }, 
            { "-", "z", "x", "c", "v", "b", "n", "m", ".", "+" }
        };
        //for SOME reason flipping this grid does not work so we need to transpose it

        keyLetterMap = new string[10, 3];
        for (int x = 0; x < 3; x++) 
        {
            for (int y = 0; y < 10; y++) 
            {
                keyLetterMap[y, x] = firstKeyLetterMap[x, y]; 
            }
        }


        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                string keyName = $"key_{x}_{y}"; // Construct the key's name
                GameObject keyObject = GameObject.Find(keyName);

                if (keyObject != null)
                {
                    keyGrid[x, y] = keyObject.transform;
                }
                else
                {
                    Debug.LogWarning($"Key {keyName} not found in the scene!");
                }
            }
        }

        capNum = (Random.Range(1,7));

        switch (capNum)
        {
            case 1:
                cap_1.enabled = true;
                answer = "notrobot";

                break;
            case 2:
                cap_2.enabled = true;
                answer = "tooeepy";

                break;
            case 3:
                cap_3.enabled = true;
                answer = "bubble";

                break;
            case 4:
                cap_4.enabled = true;
                answer = "honkshoe";

                break;
            case 5:
                cap_5.enabled = true;
                answer = "helloimd";

                break;
            case 6:
                cap_6.enabled = true;
                answer = "zmzmz";

                break;
        }


        
    }
    void UpdateCursor()
    {
        
        if (keyGrid[currentX, currentY] != null)
        {
            cursor.position = keyGrid[currentX, currentY].position;
        }
    }
    IEnumerator endMinigame()
    {
        yield return new WaitForSeconds(1);
        Dream.gameWin = true;
        Debug.Log("GAME ENDED!");
    }
    void SelectKey()
    {
        
        
        if (keyGrid[currentX, currentY] != null)
        {
            string keyLetter = keyLetterMap[currentX, currentY];

            if (keyLetter == "+")
            {
                if (typeInput == answer)
                {
                    print("WINNER");

                    winning = true;

                    capWin.enabled = true;

                    StartCoroutine(endMinigame());

                }
            }
            else if (keyLetter == "-")
            {
                RemoveLastKey();
            }
            else
            {
                typeInput += keyLetter;
                Debug.Log("String: " + typeInput);
            }
            
        }
    }

    void RemoveLastKey()
    {
        if (typeInput.Length > 0)
        {
            typeInput = typeInput.Substring(0, typeInput.Length - 1); 
            Debug.Log("string " + typeInput);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && currentY > 0)
        {
            currentY--;
            UpdateCursor();
        }
        else if (Input.GetKeyDown(KeyCode.S) && currentY < 3 - 1)
        {
            currentY++;
            UpdateCursor();
        }
        else if (Input.GetKeyDown(KeyCode.A) && currentX > 0)
        {
            currentX--;
            UpdateCursor();
        }
        else if (Input.GetKeyDown(KeyCode.D) && currentX < 10 - 1)
        {
            currentX++;
            UpdateCursor();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SelectKey();
        }

      
        
        if (typeInput != null)
        {
            inputField.text = typeInput;
        }

        //If time RUNS out you lose


    }

   


}
