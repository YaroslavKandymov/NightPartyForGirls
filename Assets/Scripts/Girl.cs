using System;
using UnityEngine;

public class Girl : MonoBehaviour
{
    public event Action MartiniCollected;

    public void CollectMartini()
    {
        MartiniCollected?.Invoke();
    }
}
