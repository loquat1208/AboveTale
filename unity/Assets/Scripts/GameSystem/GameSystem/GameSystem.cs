using UnityEngine;

public class GameSystem : MonoBehaviour
{

    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        InitOperate();
        InitChat();
    }

    public static ChatController Chat { get; private set; }

    public static OperateController Operate(Transform transform)
    {
        OperateController Operater = FindObjectOfType<OperateController>();
        Operater.transform.parent = transform;
        Operater.Initialize(transform);
        return Operater;
    }

    private void InitOperate()
    {
        if (transform.GetComponentInChildren<OperateController>())
            return;

        GameObject operater = new GameObject("Operater", typeof(OperateController));
        operater.transform.parent = gameObject.transform;
    }

    private void InitChat()
    {
        if (transform.GetComponentInChildren<ChatController>())
        {
            Chat = GetComponentInChildren<ChatController>();
            Chat.Hide();
            return;
        }

        GameObject chat = new GameObject("Chat", typeof(ChatController));
        chat.transform.parent = gameObject.transform;
        Chat = chat.GetComponent<ChatController>();
        Chat.Hide();
    }
}
