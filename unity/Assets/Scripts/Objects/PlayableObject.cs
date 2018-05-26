using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayableObject : MonoBehaviour, IInteractiveObject
{
    private Rigidbody Rigid { get { return GetComponent<Rigidbody>(); } }

    public bool IsOn { get; private set; }

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        GameSystem.GetController(transform);
    }
}
