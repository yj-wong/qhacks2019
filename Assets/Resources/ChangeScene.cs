﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void change()
    {
        SceneManager.LoadScene(2);
    }
    public void change2()
    {
        SceneManager.LoadScene(3);
    }
}
