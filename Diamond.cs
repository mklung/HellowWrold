using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diamond : MonoBehaviour
{   
    public char Input;
    public Text m_outPut_Text;

    // Start is called before the first frame update
    void Start()
    {
        DiamondFunc();

    }

    public void DiamondFunc()
    {
        m_outPut_Text.text = "";
        int Diamond_Length = (int)Input - 64;
        int Char_pos = Diamond_Length - 1;
        char[] Char_Array = new char[Diamond_Length * 2 -1];

        int char_Index = 65;

        for (int i = 0; i < Diamond_Length * 2 -1; i++)
        {
            for (int j = 0; j < Diamond_Length; j++)
            {
                if(j == Char_pos)
                {
                    Char_Array[j] = (char)char_Index;
                    Char_Array[Diamond_Length * 2 -2 - j] = (char)char_Index;
                }
                else
                {
                    Char_Array[j] = '_';
                    Char_Array[Diamond_Length * 2 - 2 - j] = '_';
                }
            }


            for (int k = 0; k < Char_Array.Length; k++)
            {
                m_outPut_Text.text += Char_Array[k];
            }
            m_outPut_Text.text += "\n";


            if( i >= Diamond_Length -1)
            {
                Char_pos ++;
                char_Index --;
            }
            else
            {
                Char_pos --;
                char_Index ++;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        DiamondFunc();
    }
}
