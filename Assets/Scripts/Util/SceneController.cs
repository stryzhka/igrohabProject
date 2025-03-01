using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private PlayerStatsController PlayerStatsController;
    public enum SceneState
    {
        PlayerAlive,
        PlayerDead
    }
    [SerializeField] private SceneState _CurrentState;

    [SerializeField] private UiController UiController;
    void OnEnable()
    {
        PlayerStatsController.PlayerDead += SetSceneState;
    }

    void OnDisable()
    {
        PlayerStatsController.PlayerDead -= SetSceneState;
    }

    void Awake()
    {
        //DontDestroyOnLoad(this.gameObject);

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetScene();
        }
       
        CheckSceneState();
    }

    public void ResetScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void ResetSceneArguments()
    {
        
    }

    private void CheckSceneState()
    {
        if (_CurrentState == SceneState.PlayerDead)
        {
            UiController.DeadState();
            
        }
    }

    public void SetSceneState(SceneState state)
    {
        _CurrentState = state;
    }
}
