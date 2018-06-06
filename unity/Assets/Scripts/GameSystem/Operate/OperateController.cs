using System;
using UnityEngine;

using UniRx;

public class OperateController : MonoBehaviour
{
    public enum Type
    {
        KeyboardFixed,
        KeyboardAndMouse,
    }

    [SerializeField] private Type type = Type.KeyboardFixed;

    private Rigidbody rigid;

    public IObservable<bool> OnInteraction { get { return Observable.EveryUpdate().Select(_ => Input.GetButton("Fire1")).DistinctUntilChanged(); } }

    public void Initialize(Transform transform)
    {
        rigid = transform.GetComponent<Rigidbody>();

        InitRudder();
    }

    private void InitRudder()
    {
        if (!rigid)
            return;

        switch (type)
        {
            case Type.KeyboardFixed:
                new KeyboardFixedRudder(rigid);
                break;
            case Type.KeyboardAndMouse:
                new KeyboardAndMouseRudder(rigid);
                break;
        }
    }
}
