﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider other)
    {
        if (other.tag == "Player")
        {

             SceneManager.LoadScene("Map2");
        }
    }
}
