using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 사용자(유저) 입력에 따라서
// 플레이어를 이동시키고 싶다!


public class PlayerMove : MonoBehaviour
{
    // 속도를 조절할 수 있는 전역변수
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 사용자 입력을 받아오자
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // 방향 설정
        Vector3 dir = new Vector3(h, v, 0);
        // 벡터 속도 일정하게 해주기
        dir.Normalize();
        // 설정된 방향에 맞춰서 오브젝트 이동
        // p = p0 + vt
        // transform.position = transform.position + dir * speed * Time.deltaTime;
        transform.position += dir * speed * Time.deltaTime;
        
    }
}
