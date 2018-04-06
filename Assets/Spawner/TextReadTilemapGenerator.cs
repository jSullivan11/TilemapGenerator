using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.SceneManagement;

public class TextReadTilemapGenerator : MonoBehaviour
{
    private Vector3 spawnPoint;
    private int dimY;
    private int xCord;
    private int yCord;
    private int readInt;
    private char spawnChar;
    private string spawnString;
    public int step;
    private int gridSizeX;
    private int gridSizeY;
    private string path;
    public string levelSchema;
    private Quaternion turned = Quaternion.Euler(0, 0, 90);
    private Quaternion flipped = Quaternion.Euler(0, 180, 0);
    private Quaternion normal = Quaternion.Euler(0, 0, 0);
    public GameObject[] levelObject;

    void Start()
    {
        path = Application.dataPath + "/" + levelSchema;
        string line;
        int intX;
        int intY;
        string X;
        string Y;
        using (StreamReader reader = new StreamReader(path))
        {
            X = reader.ReadLine();
            intX = X.Length;
        }
        using (StreamReader reader = new StreamReader(path))
        {
            line = reader.ReadToEnd();
            line = line.Replace(System.Environment.NewLine, "");
            intY = line.Length / intX;
        }
        Debug.Log("X=" + intX + " / Y=" + intY);
        yCord = 0;
        xCord = 0;
        readInt = 0;
        gridSizeX = intX;
        gridSizeY = intY;
        spawnPoint = new Vector3(xCord, yCord, 0);

        for (int y = 0; y < gridSizeY; y--)
        {
            for (int x = 0; x < gridSizeX; x++)
            {
                xCord = step * x;
                yCord = step * y;
                spawnPoint = new Vector3(xCord, yCord, 0);
                readInt++;
                spawnChar = line[(readInt--)];
                spawnString = spawnChar.ToString();
                if (spawnString == "0")
                {
                    Instantiate(levelObject[0], spawnPoint, normal);
                }
                if (spawnString == "1")
                {
                    Instantiate(levelObject[1], spawnPoint, normal);
                }
                if (spawnString == "2")
                {
                    Instantiate(levelObject[2], spawnPoint, normal);
                }
                if (spawnString == "3")
                {
                    Instantiate(levelObject[3], spawnPoint, normal);
                }
                if (spawnString == "4")
                {
                    Instantiate(levelObject[4], spawnPoint, normal);
                }
                if (spawnString == "5")
                {
                    Instantiate(levelObject[5], spawnPoint, normal);
                }
                if (spawnString == "6")
                {
                    Instantiate(levelObject[6], spawnPoint, normal);
                }
                if (spawnString == "7")
                {
                    Instantiate(levelObject[7], spawnPoint, normal);
                }
                if (spawnString == "8")
                {
                    Instantiate(levelObject[8], spawnPoint, normal);
                }
                if (spawnString == "9")
                {
                    Instantiate(levelObject[9], spawnPoint, normal);
                }
                if (spawnString == "a")
                {
                    Instantiate(levelObject[10], spawnPoint, normal);
                }
                if (spawnString == "b")
                {
                    Instantiate(levelObject[11], spawnPoint, normal);
                }
                if (spawnString == "c")
                {
                    Instantiate(levelObject[12], spawnPoint, normal);
                }
                if (spawnString == "d")
                {
                    Instantiate(levelObject[13], spawnPoint, normal);
                }
                if (spawnString == "e")
                {
                    Instantiate(levelObject[14], spawnPoint, normal);
                }
                if (spawnString == "f")
                {
                    Instantiate(levelObject[15], spawnPoint, normal);
                }
                if (spawnString == "g")
                {
                    Instantiate(levelObject[16], spawnPoint, normal);
                }
                if (spawnString == "h")
                {
                    Instantiate(levelObject[17], spawnPoint, normal);
                }
                if (spawnString == "i")
                {
                    Instantiate(levelObject[18], spawnPoint, normal);
                }
                if (spawnString == "j")
                {
                    Instantiate(levelObject[19], spawnPoint, normal);
                }
                if (spawnString == "k")
                {
                    Instantiate(levelObject[20], spawnPoint, normal);
                }
                if (spawnString == "l")
                {
                    Instantiate(levelObject[21], spawnPoint, normal);
                }
                if (spawnString == "m")
                {
                    Instantiate(levelObject[22], spawnPoint, normal);
                }
                if (spawnString == "n")
                {
                    Instantiate(levelObject[23], spawnPoint, normal);
                }
                if (spawnString == "o")
                {
                    Instantiate(levelObject[24], spawnPoint, normal);
                }
                if (spawnString == "p")
                {
                    Instantiate(levelObject[25], spawnPoint, normal);
                }
                if (spawnString == "q")
                {
                    Instantiate(levelObject[26], spawnPoint, normal);
                }
                if (spawnString == "r")
                {
                    Instantiate(levelObject[27], spawnPoint, normal);
                }
                if (spawnString == "s")
                {
                    Instantiate(levelObject[28], spawnPoint, normal);
                }
                if (spawnString == "t")
                {
                    Instantiate(levelObject[29], spawnPoint, normal);
                }
                if (spawnString == "u")
                {
                    Instantiate(levelObject[30], spawnPoint, normal);
                }
                if (spawnString == "v")
                {
                    Instantiate(levelObject[31], spawnPoint, normal);
                }
                if (spawnString == "w")
                {
                    Instantiate(levelObject[32], spawnPoint, normal);
                }
                if (spawnString == "x")
                {
                    Instantiate(levelObject[33], spawnPoint, normal);
                }
                if (spawnString == "y")
                {
                    Instantiate(levelObject[33], spawnPoint, normal);
                }
                if (spawnString == "z")
                {
                    Instantiate(levelObject[33], spawnPoint, normal);
                }
            }
            xCord = 0;
        }

    }
    public void SpawnLevel()
    {
        SceneManager.LoadScene("SpawnScene");
    }
}