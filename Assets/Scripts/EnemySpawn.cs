using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 일정 시간이 지나면 enemy를 생성



public class EnemySpawn : MonoBehaviour

{

    // enemy 프리팹
    public GameObject enemyFactory;

    // 일정한 시간
    public float createTime = 2f;
    float currentTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 생상 시간보다 현재 시간이 작으면
        // 시간을 누적
        if(currentTime < createTime)
        {
            currentTime += Time.deltaTime;
        }else
        {
            // 현재 시간이 생산시간보다 같거나 커졌다면
            // 에너미를 생산
            GameObject go = Instantiate(enemyFactory);
            // 생산된 에너미의 위치를 나의 위치로 생산
            go.transform.position = transform.position;
            // 현재시간을 0으로 초기화
            createTime = Random.Range(2f, 5f);
            // 랜덤하게 생산시간을 2~5초 사이로 지정
            currentTime = 0;
        }
    }
}
