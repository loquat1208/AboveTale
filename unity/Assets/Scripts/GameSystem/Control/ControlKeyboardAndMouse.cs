using System;
using UnityEngine;
using UniRx;

public class ControlKeyboardAndMouse : IControl
{
    private MoveController move = new MoveController();

    public ControlKeyboardAndMouse(Rigidbody rigid)
    {
        Init(rigid);
    }

    private void Init(Rigidbody rigid)
    {

    }
}
