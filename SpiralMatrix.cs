using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpiralMatrix : MonoBehaviour
{

    public int size;

    public int[] sprialMartix_Array;

    public Text Output_text;

    
    // Start is called before the first frame update
    void Start()
    {
        RunSpiralMatrix();
        Output();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Output()
    {
        Output_text.text = "";
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Output_text.text += sprialMartix_Array[j+i*size].ToString() + "  ";

            }
            Output_text.text +=  "\n";
        }
    }
    public void RunSpiralMatrix()
    {
        sprialMartix_Array = new int[size * size];
        int array_index = 0 ;
        int index = 1;
        int v_move = size;
        int h_move = -1;
        for (int i = 0; i < size; i++)
        {
            sprialMartix_Array[i] = index;
            array_index = i;
            index++;
        }
        for (int i = 0; i < size  - 1; i++)
        {
            for (int k = 0; k < size - 1 - i; k++)
            {
                array_index += v_move;
                sprialMartix_Array[array_index] = index;
                index ++;
            }
            for (int j = 0; j < size - 1 - i; j++)
            {
                array_index += h_move;
                sprialMartix_Array[array_index] = index;
                index ++;
            }
            v_move = -v_move;
            h_move = -h_move;
        }
    }
}
