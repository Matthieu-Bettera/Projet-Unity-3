using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public string scene;

    void Start()
    {
        SceneManager.LoadScene(scene);
    }

}