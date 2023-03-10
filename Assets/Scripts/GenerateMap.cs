using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMap : MonoBehaviour
{
    char[,] map = new char[3,3];

    public GameObject xPrefab, oPrefab;
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        foreach (string line in System.IO.File.ReadLines("map.txt"))
        {
            for(int j = 0; j < line.Length; j++)
            {
                map[i, j] = line[j];
            }
            i++;
        }

        // EJERCICIO


        for ( i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                if (map[i, j] == '0')
                {
                    GameObject.Instantiate(oPrefab);
                   // transform.position
                }
                
                else if(map[i, j] == 'x')
                {
                    GameObject.Instantiate(xPrefab);
                }
            }
        }


      
    }
}
