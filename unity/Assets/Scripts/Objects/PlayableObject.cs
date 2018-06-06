using UnityEngine;

using UniRx;

[RequireComponent(typeof(Rigidbody))]
public class PlayableObject : MonoBehaviour, IInteractiveObject
{
    public bool IsOn { get; private set; }

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        OperateController operater = GameSystem.Operate(transform);
        operater.OnInteraction.Subscribe(on => { IsOn = on; });
    }
}
