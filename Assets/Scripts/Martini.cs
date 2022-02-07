using UnityEngine;

public class Martini : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Girl girl))
        {
            gameObject.SetActive(false);
            girl.CollectMartini();
        }
    }
}
