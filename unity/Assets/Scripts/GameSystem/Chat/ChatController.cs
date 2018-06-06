using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ChatView))]
public class ChatController : MonoBehaviour
{
    public void Show()
    {
        gameObject.SetActive(true);

        GameSystem.Operate(transform);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
