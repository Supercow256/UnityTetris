using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TetrisMainScript : MonoBehaviour
{
    //private Transform[,] tetrisGrid = new Transform[10, 20];
    private bool[,] tetrisGrid = new bool[10, 20];
    private GameObject[] _objects; // = GameObject.FindGameObjectsWithTag("Tetromino Block");

    //private var objects = GameObject.FindGameObjectsWithTag("Tetromino Block");
    ///private GameObject[] objects = GameObject.FindGameObjectsWithTag("Tetromino Block");
    //private List<Transform> tetrisGridX = new List<Transform>();
    //private List<Transform> tetrisGrid = new List<Transform>();

    public GameObject[] allTetromino;
    public int timeInEachLevel;

    private int tetrominoSpawnX = 4;
    private int tetrominoSpawnY = 18;
    private Vector3 tetrominoSpawn;
    private float time;
    private float count;
    private GameObject currentPiece;
    private int difficulty = 0;
    private int numberOfDrops;
    private bool test;
    private int rotation = 0;
    private Transform child0Start;
    private Transform child1Start;
    private Transform child2Start;
    private Transform child3Start;
    private int child0OrigX;
    private int child1OrigX;
    private int child2OrigX;
    private int child3OrigX;
    private int child0OrigY;
    private int child1OrigY;
    private int child2OrigY;
    private int child3OrigY;


    // Start is called before the first frame update
    void Start()
    {
        difficulty = 0;
        tetrominoSpawn = new Vector3(tetrominoSpawnX, tetrominoSpawnY, 0.0f);
        SpawnPiece();
        // Debug.Log(currentPiece.transform.GetChild(0).transform.localPosition.x );
        // Debug.Log(currentPiece.transform.GetChild(1).transform.localPosition.x);
        // Debug.Log(currentPiece.transform.GetChild(0).gameObject.transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        //test = tetrisGrid[currentPiece.transform.position.x]
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            if (/*done*/currentPiece.name == "GroupO(Clone)") {
                if (!(
                (tetrisGrid[(int)(currentPiece.transform.Find("TopLeftBlock").gameObject.transform.position.x - 1), (int)(currentPiece.transform.Find("TopLeftBlock").gameObject.transform.position.y)]) ||
                (tetrisGrid[(int)(currentPiece.transform.Find("BottomLeftBlock").gameObject.transform.position.x - 1), (int)(currentPiece.transform.Find("BottomLeftBlock").gameObject.transform.position.y)])))
                {
                   
                    currentPiece.transform.position = new Vector3(currentPiece.transform.position.x - 1, currentPiece.transform.position.y, 0.0f);
                }
            }
            if (/* done*/currentPiece.name == "GroupI(Clone)")
            {
                if (!(
                (tetrisGrid[(int)(currentPiece.transform.Find("LeftMostBlock").gameObject.transform.position.x - 1), (int)(currentPiece.transform.Find("LeftMostBlock").gameObject.transform.position.y)])))
                {
                    currentPiece.transform.position = new Vector3(currentPiece.transform.position.x - 1, currentPiece.transform.position.y, 0.0f);
                }
            }
            if (/* done*/currentPiece.name == "GroupL(Clone)")
            {
                if (!(
                (tetrisGrid[(int)(currentPiece.transform.Find("TopRightBlock").gameObject.transform.position.x - 1), (int)(currentPiece.transform.Find("TopRightBlock").gameObject.transform.position.y)])||
                (tetrisGrid[(int)(currentPiece.transform.Find("LeftBottomBlock").gameObject.transform.position.x - 1), (int)(currentPiece.transform.Find("LeftBottomBlock").gameObject.transform.position.y)])))
                {
                    currentPiece.transform.position = new Vector3(currentPiece.transform.position.x - 1, currentPiece.transform.position.y, 0.0f);
                }
            }
            if (/* done*/currentPiece.name == "GroupRevL(Clone)")
            {
                if (!(
                (tetrisGrid[(int)(currentPiece.transform.Find("TopLeftBlock").gameObject.transform.position.x - 1), (int)(currentPiece.transform.Find("TopLeftBlock").gameObject.transform.position.y)]) ||
                (tetrisGrid[(int)(currentPiece.transform.Find("BottomLeftBlock").gameObject.transform.position.x - 1), (int)(currentPiece.transform.Find("BottomLeftBlock").gameObject.transform.position.y)])))
                {
                    currentPiece.transform.position = new Vector3(currentPiece.transform.position.x - 1, currentPiece.transform.position.y, 0.0f);
                }
            }
            if (/* done*/currentPiece.name == "GroupS(Clone)")
            {
                if (!(
                (tetrisGrid[(int)(currentPiece.transform.Find("TopLeftBlock").gameObject.transform.position.x - 1), (int)(currentPiece.transform.Find("TopLeftBlock").gameObject.transform.position.y)]) ||
                (tetrisGrid[(int)(currentPiece.transform.Find("BottomLeftBlock").gameObject.transform.position.x - 1), (int)(currentPiece.transform.Find("BottomLeftBlock").gameObject.transform.position.y)])))
                {
                    currentPiece.transform.position = new Vector3(currentPiece.transform.position.x - 1, currentPiece.transform.position.y, 0.0f);
                }
            }
            if (/* done*/currentPiece.name == "GroupZ(Clone)")
            {
                if (!(
                (tetrisGrid[(int)(currentPiece.transform.Find("TopLeftBlock").gameObject.transform.position.x - 1), (int)(currentPiece.transform.Find("TopLeftBlock").gameObject.transform.position.y)]) ||
                (tetrisGrid[(int)(currentPiece.transform.Find("BottomLeftBlock").gameObject.transform.position.x - 1), (int)(currentPiece.transform.Find("BottomLeftBlock").gameObject.transform.position.y)])))
                {
                    currentPiece.transform.position = new Vector3(currentPiece.transform.position.x - 1, currentPiece.transform.position.y, 0.0f);
                }
            }
            if (/* done*/currentPiece.name == "GroupT(Clone)")
            {
                if (!(
                (tetrisGrid[(int)(currentPiece.transform.Find("TopMiddleBlock").gameObject.transform.position.x - 1), (int)(currentPiece.transform.Find("TopMiddleBlock").gameObject.transform.position.y)]) ||
                (tetrisGrid[(int)(currentPiece.transform.Find("BottomLeftBlock").gameObject.transform.position.x - 1), (int)(currentPiece.transform.Find("BottomLeftBlock").gameObject.transform.position.y)])))
                {
                    currentPiece.transform.position = new Vector3(currentPiece.transform.position.x - 1, currentPiece.transform.position.y, 0.0f);
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (/*done*/currentPiece.name == "GroupO(Clone)")
            {
                if (!(
                (tetrisGrid[(int)(currentPiece.transform.Find("TopRightBlock").gameObject.transform.position.x + 1), (int)(currentPiece.transform.Find("TopRightBlock").gameObject.transform.position.y)]) ||
                (tetrisGrid[(int)(currentPiece.transform.Find("BottomRightBlock").gameObject.transform.position.x + 1), (int)(currentPiece.transform.Find("BottomRightBlock").gameObject.transform.position.y)])))
                {
                    currentPiece.transform.position = new Vector3(currentPiece.transform.position.x + 1, currentPiece.transform.position.y, 0.0f);
                }
            }
            if (/* done*/currentPiece.name == "GroupI(Clone)")
            {
                if (!(
                (tetrisGrid[(int)(currentPiece.transform.Find("RightMostBlock").gameObject.transform.position.x + 1), (int)(currentPiece.transform.Find("RightMostBlock").gameObject.transform.position.y)])))
                {
                    currentPiece.transform.position = new Vector3(currentPiece.transform.position.x + 1, currentPiece.transform.position.y, 0.0f);
                }
            }
            if (/* done*/currentPiece.name == "GroupL(Clone)")
            {
                if (!(
                (tetrisGrid[(int)(currentPiece.transform.Find("TopRightBlock").gameObject.transform.position.x + 1), (int)(currentPiece.transform.Find("TopRightBlock").gameObject.transform.position.y)]) ||
                (tetrisGrid[(int)(currentPiece.transform.Find("RightBottomBlock").gameObject.transform.position.x + 1), (int)(currentPiece.transform.Find("RightBottomBlock").gameObject.transform.position.y)])))
                {
                    currentPiece.transform.position = new Vector3(currentPiece.transform.position.x + 1, currentPiece.transform.position.y, 0.0f);
                }
            }
            if (/* done*/currentPiece.name == "GroupRevL(Clone)")
            {
                if (!(
                (tetrisGrid[(int)(currentPiece.transform.Find("TopLeftBlock").gameObject.transform.position.x + 1), (int)(currentPiece.transform.Find("TopLeftBlock").gameObject.transform.position.y)]) ||
                (tetrisGrid[(int)(currentPiece.transform.Find("BottomRightBlock").gameObject.transform.position.x + 1), (int)(currentPiece.transform.Find("BottomRightBlock").gameObject.transform.position.y)])))
                {
                    currentPiece.transform.position = new Vector3(currentPiece.transform.position.x + 1, currentPiece.transform.position.y, 0.0f);
                }
            }
            if (/* done*/currentPiece.name == "GroupS(Clone)")
            {
                if (!(
                (tetrisGrid[(int)(currentPiece.transform.Find("TopRightBlock").gameObject.transform.position.x + 1), (int)(currentPiece.transform.Find("TopRightBlock").gameObject.transform.position.y)]) ||
                (tetrisGrid[(int)(currentPiece.transform.Find("BottomRightBlock").gameObject.transform.position.x + 1), (int)(currentPiece.transform.Find("BottomRightBlock").gameObject.transform.position.y)])))
                {
                    currentPiece.transform.position = new Vector3(currentPiece.transform.position.x + 1, currentPiece.transform.position.y, 0.0f);
                }
            }
            if (/* done*/currentPiece.name == "GroupZ(Clone)")
            {
                if (!(
                (tetrisGrid[(int)(currentPiece.transform.Find("TopRightBlock").gameObject.transform.position.x + 1), (int)(currentPiece.transform.Find("TopRightBlock").gameObject.transform.position.y)])||
                (tetrisGrid[(int)(currentPiece.transform.Find("BottomRightBlock").gameObject.transform.position.x + 1), (int)(currentPiece.transform.Find("BottomRightBlock").gameObject.transform.position.y)])))
                {
                    currentPiece.transform.position = new Vector3(currentPiece.transform.position.x + 1, currentPiece.transform.position.y, 0.0f);
                }
            }
            if (/* done*/currentPiece.name == "GroupT(Clone)")
            {
                if (!(
                (tetrisGrid[(int)(currentPiece.transform.Find("TopMiddleBlock").gameObject.transform.position.x + 1), (int)(currentPiece.transform.Find("TopMiddleBlock").gameObject.transform.position.y)]) ||
                (tetrisGrid[(int)(currentPiece.transform.Find("BottomRightBlock").gameObject.transform.position.x + 1), (int)(currentPiece.transform.Find("BottomRightBlock").gameObject.transform.position.y)])))
                {
                    currentPiece.transform.position = new Vector3(currentPiece.transform.position.x + 1, currentPiece.transform.position.y, 0.0f);
                }
            }

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //currentPiece.transform.eulerAngles = new Vector3 (currentPiece.transform.eulerAngles.x, currentPiece.transform.eulerAngles.y, currentPiece.transform.eulerAngles.z - 90);

            if (rotation == 0)
            {
                currentPiece.transform.GetChild(0).transform.localPosition = new Vector3(child0OrigX, child0OrigY, 0.0f);
                currentPiece.transform.GetChild(1).transform.localPosition = new Vector3(child1OrigX, child1OrigY, 0.0f);
                currentPiece.transform.GetChild(2).transform.localPosition = new Vector3(child2OrigX, child2OrigY, 0.0f);
                currentPiece.transform.GetChild(3).transform.localPosition = new Vector3(child3OrigX, child3OrigY, 0.0f);
                /*
                currentPiece.transform.GetChild(0).transform.localPosition = new Vector3(currentPiece.transform.position.x + child0OrigX.currentPiece.transform.position.y + child0OrigY, 0.0f);
                currentPiece.transform.GetChild(1).transform.localPosition = new Vector3(currentPiece.transform.position.x + child1OrigX.currentPiece.transform.position.y + child1OrigY, 0.0f);
                currentPiece.transform.GetChild(2).transform.localPosition = new Vector3(currentPiece.transform.position.x + child2OrigX.currentPiece.transform.position.y + child2OrigY, 0.0f);
                currentPiece.transform.GetChild(3).transform.localPosition = new Vector3(currentPiece.transform.position.x + child3OrigX.currentPiece.transform.position.y + child3OrigY, 0.0f);
                */

                /*
                for (int i = 0; i < currentPiece.transform.childCount; i++)
                {
                    int tempX, tempY;
                    //tempX = (int)currentPiece.transform.GetChild(i).transform.localPosition.x;
                    //tempY = (int)currentPiece.transform.GetChild(i).transform.localPosition.y;
                    currentPiece.transform.GetChild(i).transform.localPosition = new Vector3(child0OrigX, tempY, 0.0f);
                }
                */
            }

            else if (rotation == 1)
            {
                currentPiece.transform.GetChild(0).transform.localPosition = new Vector3(child0OrigY, child0OrigX, 0.0f);
                currentPiece.transform.GetChild(1).transform.localPosition = new Vector3(child1OrigY, child1OrigX, 0.0f);
                currentPiece.transform.GetChild(2).transform.localPosition = new Vector3(child2OrigY, child2OrigX, 0.0f);
                currentPiece.transform.GetChild(3).transform.localPosition = new Vector3(child3OrigY, child3OrigX, 0.0f);
                /*
                currentPiece.transform.GetChild(0).transform.localPosition = new Vector3(currentPiece.transform.position.x + child0OrigY.currentPiece.transform.position.y + child0OrigX, 0.0f);
                currentPiece.transform.GetChild(1).transform.localPosition = new Vector3(currentPiece.transform.position.x + child1OrigY.currentPiece.transform.position.y + child1OrigX, 0.0f);
                currentPiece.transform.GetChild(2).transform.localPosition = new Vector3(currentPiece.transform.position.x + child2OrigY.currentPiece.transform.position.y + child2OrigX, 0.0f);
                currentPiece.transform.GetChild(3).transform.localPosition = new Vector3(currentPiece.transform.position.x + child3OrigY.currentPiece.transform.position.y + child3OrigX, 0.0f);
                */
                /*
                for (int i = 0; i < currentPiece.transform.childCount; i++)
                {
                    int tempX, tempY;
                    currentPiece.transform.GetChild(i).transform.localPosition = new Vector3(-tempX, tempY, 0.0f);
                }
                */
            }
            else if (rotation == 2)
            { 
                currentPiece.transform.GetChild(0).transform.localPosition = new Vector3(-child0OrigX, -child0OrigY, 0.0f);
                currentPiece.transform.GetChild(1).transform.localPosition = new Vector3(-child1OrigX, -child1OrigY, 0.0f);
                currentPiece.transform.GetChild(2).transform.localPosition = new Vector3(-child2OrigX, -child2OrigY, 0.0f);
                currentPiece.transform.GetChild(3).transform.localPosition = new Vector3(-child3OrigX, -child3OrigY, 0.0f);
                /*
                currentPiece.transform.GetChild(0).transform.localPosition = new Vector3(currentPiece.transform.position.x + child0OrigX.currentPiece.transform.position.y - child1OrigY, 0.0f);
                currentPiece.transform.GetChild(1).transform.localPosition = new Vector3(currentPiece.transform.position.x + child1OrigX.currentPiece.transform.position.y - child1OrigY, 0.0f);
                currentPiece.transform.GetChild(2).transform.localPosition = new Vector3(currentPiece.transform.position.x + child2OrigX.currentPiece.transform.position.y - child2OrigY, 0.0f);
                currentPiece.transform.GetChild(3).transform.localPosition = new Vector3(currentPiece.transform.position.x + child3OrigX.currentPiece.transform.position.y - child3OrigY, 0.0f);
                */

                /*
                for (int i = 0; i < currentPiece.transform.childCount; i++)
                {
                    int tempX, tempY;
                    tempX = (int)currentPiece.transform.GetChild(i).transform.localPosition.x;
                    tempY = (int)currentPiece.transform.GetChild(i).transform.localPosition.y;
                    currentPiece.transform.GetChild(i).transform.localPosition = new Vector3(tempX, -tempY, 0.0f);
                }
                */
            }
            else if (rotation == 3)
            {
                currentPiece.transform.GetChild(0).transform.localPosition = new Vector3(-child0OrigY, child0OrigX, 0.0f);
                currentPiece.transform.GetChild(1).transform.localPosition = new Vector3(-child1OrigY, child1OrigX, 0.0f);
                currentPiece.transform.GetChild(2).transform.localPosition = new Vector3(-child2OrigY, child2OrigX, 0.0f);
                currentPiece.transform.GetChild(3).transform.localPosition = new Vector3(-child3OrigY, child3OrigX, 0.0f);
                /*
                currentPiece.transform.GetChild(0).transform.localPosition = new Vector3(currentPiece.transform.position.x - child0OrigY.currentPiece.transform.position.y + child0OrigX, 0.0f);
                currentPiece.transform.GetChild(1).transform.localPosition = new Vector3(currentPiece.transform.position.x - child1OrigY.currentPiece.transform.position.y + child1OrigX, 0.0f);
                currentPiece.transform.GetChild(2).transform.localPosition = new Vector3(currentPiece.transform.position.x - child2OrigY.currentPiece.transform.position.y + child2OrigX, 0.0f);
                currentPiece.transform.GetChild(3).transform.localPosition = new V  ector3(currentPiece.transform.position.x - child3OrigY.currentPiece.transform.position.y + child3OrigX, 0.0f);
                */
            }
            rotation++;
            
            if (rotation == 4)
            {
                rotation = 0;
            }
            //NEED TO MAKE IT SO THAT WHEN THE SHAPE ROTATES ALL OF THE SMALL BOCKS CHANGE POSITIONS AND THE MATRIX CHANGES TOO
        }
        
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            PieceFall();
        }
        
    }
    void FixedUpdate()
    {
        time += Time.deltaTime;
        count += Time.deltaTime;

        if (currentPiece.transform.position.y > 0 &&
            tetrisGrid[ (int) currentPiece.transform.GetChild(0).transform.position.x, (int) currentPiece.transform.GetChild(0).transform.position.y - 1] == false &&
            tetrisGrid[ (int) currentPiece.transform.GetChild(1).transform.position.x, (int) currentPiece.transform.GetChild(1).transform.position.y - 1] == false &&
            tetrisGrid[ (int) currentPiece.transform.GetChild(2).transform.position.x, (int) currentPiece.transform.GetChild(2).transform.position.y - 1] == false &&
            tetrisGrid[ (int) currentPiece.transform.GetChild(3).transform.position.x, (int) currentPiece.transform.GetChild(3).transform.position.y - 1] == false)

        {
            if ((Math.Round(count, 2) - Math.Round((0.6f - (0.1 * difficulty)), 2)) == 0)
            {
                PieceFall();
                System.Threading.Thread.Sleep(100);
                //setMatrixTrue(0, 0);
                //Debug.Log(currentPiece.transform.position.y);
            }
        }
        else
        {

            setMatrixTrue(0,0);
            SpawnPiece();
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    Debug.Log("(" + i + ", " + j + ") == " + tetrisGrid[i,j]);
                }
            }
        }

        if (time % timeInEachLevel == 0)
        {
            difficulty++;
        }
        
        
        int trueRowCount = 0;
        for (int j =0; j < 20; j++){
            for (int i = 0; i < 10; i++)
            {
                if(tetrisGrid[i,j]){
                    trueRowCount++;
                    //break;
                }

                /*
                if (fullRow == true)
                {
                    _objects = GameObject.FindGameObjectsWithTag("Tetromino Block");

                    for (int k = 0; k < _objects.Length; k++)
                    {
                        if ((int)_objects[k].transform.position.y == j)
                        {
                            Destroy(_objects[k].gameObject);
                        }
                    }
                    fullRow = true;
                }
                */
            }
            if (trueRowCount == 10)
            {
                for (int k = 0; k < 10; k++)
                {
                    if ((int) _objects[k].transform.position.y == j)
                    {
                        Destroy(_objects[k].gameObject);
                    }
                }
            }
            trueRowCount = 0;
        }
        


        /*
        int countTrue = 0;
        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 20; col++)
            {
                countTrue++;
                //fullRow &&= tetrisGrid(row, col);
            }
            if (countTrue == 10)
            {
                foreach (object o in objects)
                {
                    GameObject g = (GameObject)o;
                    if((int) g.transform.position.y == row)
                    {
                        Destroy(g);
                    }
                }
                countTrue = 0;
            }
        }
        */
    }

    private void SpawnPiece()
    {
        int rand = UnityEngine.Random.Range(0, allTetromino.Length);

        currentPiece = Instantiate(allTetromino[rand], tetrominoSpawn, Quaternion.identity);


        child0OrigX = (int)currentPiece.transform.GetChild(0).transform.localPosition.x;
        child0OrigY = (int)currentPiece.transform.GetChild(0).transform.localPosition.y;
        child1OrigX = (int)currentPiece.transform.GetChild(1).transform.localPosition.x;
        child1OrigY = (int)currentPiece.transform.GetChild(1).transform.localPosition.y;
        child2OrigX = (int)currentPiece.transform.GetChild(2).transform.localPosition.x;
        child2OrigY = (int)currentPiece.transform.GetChild(2).transform.localPosition.y;
        child3OrigX = (int)currentPiece.transform.GetChild(3).transform.localPosition.x;
        child3OrigY = (int)currentPiece.transform.GetChild(3).transform.localPosition.y;


        //child0Start.position = new Vector3(currentPiece.transform.position.x, currentPiece.transform.position.y, 0);
        //Debug.Log("row " + (tetrominoSpawnX + (int)currentPiece.transform.GetChild(0).transform.localPosition.x) + "col " + (tetrominoSpawnY + (int)currentPiece.transform.GetChild(0).transform.localPosition.y));
        //Debug.Log("row " + (tetrominoSpawnX + (int)currentPiece.transform.GetChild(1).transform.localPosition.x) + "col " + (tetrominoSpawnY + (int)currentPiece.transform.GetChild(1).transform.localPosition.y));
        //Debug.Log("row " + (tetrominoSpawnX + (int)currentPiece.transform.GetChild(2).transform.localPosition.x) + "col " + (tetrominoSpawnY + (int)currentPiece.transform.GetChild(2).transform.localPosition.y));
        //Debug.Log("row " + (tetrominoSpawnX + (int)currentPiece.transform.GetChild(3).transform.localPosition.x) + "col " + (tetrominoSpawnY + (int)currentPiece.transform.GetChild(3).transform.localPosition.y));



    }
    private void PieceFall()
    {
        //Debug.Log(Math.Round(count,2));
        //if ((Math.Round(count, 2) - Math.Round(timeIncrement, 2)) == 0)
        //{
        //Debug.Log("Piece fall 2");
        //if (currentPiece.transform.position.y > 0)
        //{
        // setMatrixFalse();

        /*
         if (!(
            (tetrisGrid[(int)(currentPiece.transform.position.x + currentPiece.transform.Find("TopLeftBlock").gameObject.transform.localPosition.x - 1), (int)(currentPiece.transform.position.y + currentPiece.transform.GetChild(0).gameObject.transform.localPosition.y)]) &&
            (tetrisGrid[(int)(currentPiece.transform.position.x + currentPiece.transform.Find("BottomLeftBlock").gameObject.transform.localPosition.x - 1), (int)(currentPiece.transform.position.y + currentPiece.transform.GetChild(1).gameObject.transform.localPosition.y)])))
         */


                if (/* done*/currentPiece.name == "GroupO(Clone)")
                {
                    if (!(
                    (tetrisGrid[(int)(currentPiece.transform.Find("BottomRightBlock").gameObject.transform.position.x), (int)(currentPiece.transform.Find("BottomRightBlock").gameObject.transform.position.y - 1)]) ||
                    (tetrisGrid[(int)(currentPiece.transform.Find("BottomLeftBlock").gameObject.transform.position.x), (int)(currentPiece.transform.Find("BottomLeftBlock").gameObject.transform.position.y - 1)])))
                    {
                        //setMatrixFalse();
                        currentPiece.transform.position = new Vector3(currentPiece.transform.position.x, currentPiece.transform.position.y - 1, 0.0f);
                        //setMatrixTrue();
                    }
                    else
                {
                    setMatrixTrue(0, 0);
                    SpawnPiece();
                }
            }
                if (/* done*/currentPiece.name == "GroupI(Clone)")
                {
                    if (!(
                    (tetrisGrid[(int)(currentPiece.transform.Find("LeftMostBlock").gameObject.transform.position.x), (int)(currentPiece.transform.Find("LeftMostBlock").gameObject.transform.position.y -1 )]) ||
                    (tetrisGrid[(int)(currentPiece.transform.Find("MiddleLeftBlock").gameObject.transform.position.x), (int)(currentPiece.transform.Find("MiddleLeftBlock").gameObject.transform.position.y - 1)])||
                    (tetrisGrid[(int)(currentPiece.transform.Find("MiddleRightBlock").gameObject.transform.position.x), (int)(currentPiece.transform.Find("MiddleRightBlock").gameObject.transform.position.y - 1)])||
                    (tetrisGrid[(int)(currentPiece.transform.Find("RightMostBlock").gameObject.transform.position.x), (int)(currentPiece.transform.Find("RightMostBlock").gameObject.transform.position.y - 1)])))
                    {
                    //setMatrixFalse();
                    currentPiece.transform.position = new Vector3(currentPiece.transform.position.x, currentPiece.transform.position.y - 1, 0.0f);
                    //setMatrixTrue();
                    }
                else
                {
                    setMatrixTrue(0, 0);
                    SpawnPiece();
                }
            }
           
                if (/* done*/currentPiece.name == "GroupL(Clone)")
                {
                    if (!(
                    (tetrisGrid[(int)(currentPiece.transform.Find("MiddleBottomBlock").gameObject.transform.position.x), (int)(currentPiece.transform.Find("MiddleBottomBlock").gameObject.transform.position.y - 1)]) ||
                    (tetrisGrid[(int)(currentPiece.transform.Find("RightBottomBlock").gameObject.transform.position.x), (int)(currentPiece.transform.Find("RightBottomBlock").gameObject.transform.position.y - 1)]) ||
                    (tetrisGrid[(int)(currentPiece.transform.Find("LeftBottomBlock").gameObject.transform.position.x), (int)(currentPiece.transform.Find("LeftBottomBlock").gameObject.transform.position.y - 1)])))
                    {
                    //setMatrixFalse();
                    currentPiece.transform.position = new Vector3(currentPiece.transform.position.x, currentPiece.transform.position.y - 1, 0.0f);
                    //setMatrixTrue();
                    }
                else
                {
                    setMatrixTrue(0, 0);
                    SpawnPiece();
                }
            }
                if (/* done*/currentPiece.name == "GroupRevL(Clone)")
                {
                    if (!(
                    (tetrisGrid[(int)(currentPiece.transform.Find("BottomMiddleBlock").gameObject.transform.position.x), (int)(currentPiece.transform.Find("BottomMiddleBlock").gameObject.transform.position.y - 1)]) ||
                    (tetrisGrid[(int)(currentPiece.transform.Find("BottomRightBlock").gameObject.transform.position.x), (int)(currentPiece.transform.Find("BottomRightBlock").gameObject.transform.position.y - 1)]) ||
                    (tetrisGrid[(int)(currentPiece.transform.Find("BottomLeftBlock").gameObject.transform.position.x), (int)(currentPiece.transform.Find("BottomLeftBlock").gameObject.transform.position.y - 1)])))
                    {
                        //setMatrixFalse();
                        currentPiece.transform.position = new Vector3(currentPiece.transform.position.x, currentPiece.transform.position.y - 1, 0.0f);
                        //setMatrixTrue();
                        }
                else
                {
                    setMatrixTrue(0,0);
                    SpawnPiece();
                }
            }
                if (/* done*/currentPiece.name == "GroupS(Clone)")
                {
                    if (!(
                    (tetrisGrid[(int)(currentPiece.transform.Find("BottomRightBlock").gameObject.transform.position.x), (int)(currentPiece.transform.Find("BottomRightBlock").gameObject.transform.position.y - 1)]) ||
                    (tetrisGrid[(int)(currentPiece.transform.Find("BottomLeftBlock").gameObject.transform.position.x), (int)(currentPiece.transform.Find("BottomLeftBlock").gameObject.transform.position.y - 1)])))
                    {
                    //setMatrixFalse();
                    currentPiece.transform.position = new Vector3(currentPiece.transform.position.x, currentPiece.transform.position.y - 1, 0.0f);
                    //setMatrixTrue();
                  }
                else
                {
                    setMatrixTrue(0, 0);
                    SpawnPiece();
                }
            }
                if (/* done*/currentPiece.name == "GroupZ(Clone)")
                {
                    if (!(
                    (tetrisGrid[(int)(currentPiece.transform.Find("BottomRightBlock").gameObject.transform.position.x), (int)(currentPiece.transform.Find("BottomRightBlock").gameObject.transform.position.y - 1)]) ||
                    (tetrisGrid[(int)(currentPiece.transform.Find("BottomLeftBlock").gameObject.transform.position.x), (int)(currentPiece.transform.Find("BottomLeftBlock").gameObject.transform.position.y - 1)])))
                    {
                    //setMatrixFalse();
                    currentPiece.transform.position = new Vector3(currentPiece.transform.position.x, currentPiece.transform.position.y - 1, 0.0f);
                    //setMatrixTrue();
                    }
                else
                {
                    setMatrixTrue(0, 0);
                    SpawnPiece();
                }
            }
                if (/* done*/currentPiece.name == "GroupT(Clone)")
                {
                    if (!(
                    (tetrisGrid[(int)(currentPiece.transform.Find("BottomRightBlock").gameObject.transform.position.x), (int)(currentPiece.transform.Find("BottomRightBlock").gameObject.transform.position.y - 1)]) ||
                    (tetrisGrid[(int)(currentPiece.transform.Find("BottomMiddleBlock").gameObject.transform.position.x), (int)(currentPiece.transform.Find("BottomMiddleBlock").gameObject.transform.position.y - 1)]) ||
                    (tetrisGrid[(int)(currentPiece.transform.Find("BottomLeftBlock").gameObject.transform.position.x), (int)(currentPiece.transform.Find("BottomLeftBlock").gameObject.transform.position.y - 1)])))
                    {
                    currentPiece.transform.position = new Vector3(currentPiece.transform.position.x, currentPiece.transform.position.y - 1, 0.0f);
                }

                    
            }
                    
                /*
                if (tetrisGrid[])
            {

            }
            else (){
                SpawnPiece();
            }
            */

            /*for (int i = 0; i < currentPiece.transform.childCount; i++)
            {
                tetrisGrid[(int)(currentPiece.transform.position.x + currentPiece.transform.GetChild(i).localPosition.x), (int)(currentPiece.transform.position.y + currentPiece.transform.GetChild(i).localPosition.y)] = false;
                tetrisGrid[(int)(currentPiece.transform.position.x + currentPiece.transform.GetChild(i).localPosition.x), (int)(currentPiece.transform.position.y + currentPiece.transform.GetChild(i).localPosition.y - 1)] = true;

            }
            */

            //currentPiece.transform.position = new Vector3(currentPiece.transform.position.x, currentPiece.transform.position.y - 1, 0.0f);
            count = 0;
            numberOfDrops++;
            
             _objects = GameObject.FindGameObjectsWithTag("Tetromino Block");



        //}
    }

    private void setMatrixTrue(int changeInX, int changeInY)
    {
        for (int i = 0; i < currentPiece.transform.childCount; i++)
        {
            tetrisGrid[(int)currentPiece.transform.GetChild(i).transform.position.x + changeInX, (int)currentPiece.transform.GetChild(i).transform.position.y + changeInY] = true;
        }

        /*
        tetrisGrid[(int)currentPiece.transform.position.x + (int)currentPiece.transform.GetChild(0).transform.localPosition.x, (int)currentPiece.transform.position.y + (int)currentPiece.transform.GetChild(0).transform.localPosition.y] = true;
        tetrisGrid[(int)currentPiece.transform.position.x + (int)currentPiece.transform.GetChild(1).transform.localPosition.x, (int)currentPiece.transform.position.y + (int)currentPiece.transform.GetChild(1).transform.localPosition.y] = true;
        tetrisGrid[(int)currentPiece.transform.position.x + (int)currentPiece.transform.GetChild(2).transform.localPosition.x, (int)currentPiece.transform.position.y + (int)currentPiece.transform.GetChild(2).transform.localPosition.y] = true;
        tetrisGrid[(int)currentPiece.transform.position.x + (int)currentPiece.transform.GetChild(3).transform.localPosition.x, (int)currentPiece.transform.position.y + (int)currentPiece.transform.GetChild(3).transform.localPosition.y] = true;
    */
    }

    private void setMatrixFalse(int changeInX, int changeInY)
    {
        for (int i = 0; i < currentPiece.transform.childCount; i++)
        {
            tetrisGrid[(int)currentPiece.transform.GetChild(i).transform.position.x + changeInX, (int)currentPiece.transform.GetChild(i).position.y + changeInY] = false;
        }
        /*
        tetrisGrid[(int)currentPiece.transform.position.x + (int)currentPiece.transform.GetChild(0).transform.localPosition.x, (int)currentPiece.transform.position.y + (int)currentPiece.transform.GetChild(0).transform.localPosition.y] = false;
        tetrisGrid[(int)currentPiece.transform.position.x + (int)currentPiece.transform.GetChild(1).transform.localPosition.x, (int)currentPiece.transform.position.y + (int)currentPiece.transform.GetChild(1).transform.localPosition.y] = false;
        tetrisGrid[(int)currentPiece.transform.position.x + (int)currentPiece.transform.GetChild(2).transform.localPosition.x, (int)currentPiece.transform.position.y + (int)currentPiece.transform.GetChild(2).transform.localPosition.y] = false;
        tetrisGrid[(int)currentPiece.transform.position.x + (int)currentPiece.transform.GetChild(3).transform.localPosition.x, (int)currentPiece.transform.position.y + (int)currentPiece.transform.GetChild(3).transform.localPosition.y] = false;
        */
        }

    //create a function that changes the values of the matrix based on 2 arguements
    
    // think of better name 

    private void ChangeMatrixValues(int changeInX, int changeInY)
    {
        
        //Debug.Log("piece is (" + currentPiece.transform.position.x + ", " + currentPiece.transform.position.y + ")");
        
        for (int i = 0; i < currentPiece.transform.childCount; i++)
        {
            tetrisGrid[(int)currentPiece.transform.GetChild(i).transform.position.x + changeInX, (int)currentPiece.transform.position.y] = true;
        }
        
    }

}
