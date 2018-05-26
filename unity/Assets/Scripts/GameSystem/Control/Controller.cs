using System;
using UnityEngine;

using UniRx;

public class Controller : MonoBehaviour
{
    public enum Type
    {
        KeyboardFixed,
        KeyboardAndMouse,
    }

    [SerializeField] private Type type = Type.KeyboardFixed;

    private IControl control;

    public IObservable<bool> OnInteraction { get { return Observable.EveryUpdate().Select(_ => Input.GetButton("Fire1")).DistinctUntilChanged(); } }

    public void Initialize()
    {
        SetController();
    }

    private void SetController()
    {
        Rigidbody rigid = transform.parent.GetComponent<Rigidbody>();

        if (!rigid)
            return;

        switch (type)
        {
            case Type.KeyboardFixed:
                control =  new ControlKeyboardFixed(rigid);
                break;
            case Type.KeyboardAndMouse:
                control = new ControlKeyboardAndMouse(rigid);
                break;
        }
    }
}
