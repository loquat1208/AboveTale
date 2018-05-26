using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController
{
    private MoveModel model;

    public MoveController(float? speed = null)
    {
        Initialize(speed);
    }

    private void Initialize(float? speed)
    {
        model = new MoveModel();

        if (speed.HasValue)
            model.SetSpeed(speed.Value);
    }

    public void Move(Rigidbody rigid, Vector3 dir)
    {
        rigid.velocity = dir * model.Speed;
    }
}
