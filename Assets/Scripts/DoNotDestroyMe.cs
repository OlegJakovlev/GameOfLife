using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroyMe : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
