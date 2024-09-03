using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class SceneManagement : MonoBehaviour
{
    [SerializeField] UnityEvent togglePassthrough;
    private ARSession ARSession;
    // Start is called before the first frame update
    void Start()
    {
        ARSession = GetComponent<ARSession>();
        togglePassthrough.Invoke();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void LoadSceneName(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void LoadLab()
    {
        LoadSceneName(1);
    }
    public void LoadPioneer()
    {
        LoadSceneName(2);
    }
    public void LoadStart()
    {
        LoadSceneName(0);
    }
    public void EnablePassThrough()
    {
        ARSession.enabled = true;
    }
}
