using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public static Controller GetController(Transform transform)
    {
        Controller controller = FindObjectOfType<Controller>();
        controller.transform.parent = transform;
        controller.Initialize();
        return controller;
    }
    
    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        SetController();
    }

    private void SetController()
    {
        if (transform.GetComponentInChildren<Controller>())
            return;

        GameObject controller = new GameObject("Controller", typeof(Controller));
        controller.transform.parent = gameObject.transform;
    }
}
