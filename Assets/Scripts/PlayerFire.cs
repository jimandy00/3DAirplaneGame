using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Fire1 클릭하면
// 미사아일 바알사

public class PlayerFire : MonoBehaviour
{
    // 불렛 주문서(생성 할 미사일 오브젝트를 담는 변수)
    public GameObject BulletFactory;

    // 미사일 오브젝트의 위치를 지정 할 포인트
    public GameObject firePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 유저가 Fire1을 클릭하면
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject go = Instantiate(BulletFactory);
            go.transform.position = firePosition.transform.position;
        }
        // 유니티한테 불렛 만들어달라고 요청
        // 불렛을 배송 받으면 용도에 맞게 사용
    }
}
