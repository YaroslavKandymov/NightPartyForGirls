using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Queue<Girl> _girls = new Queue<Girl>();
    private int _martiniCounter;

    public void OnMartiniCollected()
    {
        _martiniCounter++;
    }
}
