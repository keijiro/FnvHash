using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        var p = new int[5];

        for (var i = -100; i <= 100; i++)
            p[FnvHash.Hash32.Compute(i, p.Length)]++;

        foreach (var n in p)
            Debug.Log(n);
    }
}
