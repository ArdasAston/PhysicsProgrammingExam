using System.Collections;
using UnityEngine;

public class Sfera : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DestroySfera());
    }

    private IEnumerator DestroySfera()
    {
        yield return new WaitForSeconds(7f);
        Destroy((this.gameObject));
    }
}
