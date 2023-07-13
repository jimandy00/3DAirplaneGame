using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 화면의 아래로 이동
// 플레이어 쫓기



public class EnemyMove : MonoBehaviour
{
    // 속도
    public float speed = 5f;

    // 방향
    Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {

        // 랜덤하게 숫자를 정하자!
        int randomNum = Random.Range(0, 10);
        print(randomNum);
        if (randomNum < 3) // 30% 확률 이내라면
        {
            // 플레이어 오브젝트 찾기
            GameObject player = GameObject.Find("Player");
            // 플레이어 오브젝트 방향을 계산
            dir = player.transform.position - transform.position;
            dir.Normalize();
        }else
        {
            dir = Vector3.down;
        }

    }

    // Update is called once per frame
    void Update()
    {

        // 플레이어 오브젝트 쫓기

         transform.position += dir * speed * Time.deltaTime;
    }
}
