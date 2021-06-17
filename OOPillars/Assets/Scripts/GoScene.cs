using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoScene : MonoBehaviour
{
    // Update is called once per frame
    public void LaunchIt()
    {
        SceneManager.LoadScene(1);
    }
}
