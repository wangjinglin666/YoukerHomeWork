﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AgainNo : MonoBehaviour
{
    public void again()
    {
        SceneManager.LoadScene("StartGameUI");
    }
}
