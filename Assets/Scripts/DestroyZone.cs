using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 나와 부딪힌 오브젝트 삭제

public class DestroyZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
