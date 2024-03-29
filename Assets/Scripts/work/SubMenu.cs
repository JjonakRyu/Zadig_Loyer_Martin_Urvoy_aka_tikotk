using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SubMenu : MonoBehaviour
{
    public string _selfLV;
    public void Menu()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void Lv1()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Lv2()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void Lv3()
    {
        SceneManager.LoadSceneAsync(3);
    }

    public void Lv4()
    {
        SceneManager.LoadSceneAsync(4);
    }

    public void selfSpawn()
    {
        SceneManager.LoadSceneAsync(_selfLV);
    }
}
