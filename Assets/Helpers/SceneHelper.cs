﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Helpers
{
    public class SceneHelper : MonoBehaviour
    {    
        public void ChangeToScene(string sceneName)
        {
            if (String.IsNullOrEmpty(sceneName) == false) {
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
