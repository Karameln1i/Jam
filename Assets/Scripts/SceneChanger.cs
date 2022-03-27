using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void SceneChange(int _sceneValue)
    { 
        SceneManager.LoadScene(_sceneValue);
    }
}
