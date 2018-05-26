using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
[RequireComponent(typeof(Rigidbody))]
public class TalkableObject : MonoBehaviour, IInteractiveObject
{
    [SerializeField] private float triggerRadius = 1.5f;

    private PlayableObject Player { get { return FindObjectOfType<PlayableObject>(); } }
    private SphereCollider Trigger { get { return GetComponentInChildren<SphereCollider>(); } }

    public bool IsOn { get; private set; }

    void Start()
    {
        if (!Trigger)
            CreatTrigger();
    }

    void OnTriggerStay(Collider collider)
    {
        bool isPlayer = collider.gameObject == Player.gameObject;
        if (isPlayer && Player.IsOn)
            Talk();
    }

    private void CreatTrigger()
    {
        SphereCollider trigger = new GameObject("Trigger", typeof(SphereCollider)).GetComponent<SphereCollider>();
        trigger.transform.SetParent(transform, false);
        trigger.isTrigger = true;
        trigger.radius = triggerRadius;
    }

    private void Talk()
    {
        Debug.Log("Talk");
    }
}
