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
                    GameObject.Instantiate(oPrefab, new Vector3(-j, i, 0), Quaternion.identity);
                    //transform.position (no se poner la posicion profe);
                }
                
                else if(map[i, j] == 'x')
                {
                    GameObject.Instantiate(xPrefab, new Vector3(-j, i, 0), Quaternion.identity);
                }
            }
        }



        //Stack<int> pila = new Stack<int>();
        //pila.Push(-8);
        //pila.Push(1);
        //pila.Push(-3);
        //pila.Push(10);

        //while(pila.Count > 0) // puedo sacar elementos de la fila si no tiene 0 elementos
        //{
        //    int number = pila.Pop();
        //    Debug.Log(number);
        //}


        Queue<int> cola = new Queue<int>();
        cola.Enqueue(0);
        cola.Enqueue(11);
        cola.Enqueue(8);
        cola.Enqueue(-3);

        while(cola.Count > 0)
        {
            int nb = cola.Dequeue();
            Debug.Log(nb);
        }



      
    }
}
