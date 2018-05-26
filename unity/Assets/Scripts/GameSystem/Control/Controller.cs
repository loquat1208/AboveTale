using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public enum Type
    {
        KeyboardFixed,
        KeyboardAndMouse,
    }

    [SerializeField] private Type type = Type.KeyboardFixed;

    private IControl control;

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
