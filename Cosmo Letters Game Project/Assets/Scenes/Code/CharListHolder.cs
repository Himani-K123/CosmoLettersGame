using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class CharListHolder : MonoBehaviour
{
    public static List<char> charList;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    
}
