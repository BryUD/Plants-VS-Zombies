using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToScene: MonoBehaviour
{
    [SerializeField]
    private string _sceneName;
    public void Loadscene()
    {
        SceneManager.LoadScene(_sceneName);
    }
}
