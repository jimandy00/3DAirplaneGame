using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Fire1 Ŭ���ϸ�
// �̻���� �پ˻�

public class PlayerFire : MonoBehaviour
{
    // �ҷ� �ֹ���(���� �� �̻��� ������Ʈ�� ��� ����)
    public GameObject BulletFactory;

    // �̻��� ������Ʈ�� ��ġ�� ���� �� ����Ʈ
    public GameObject firePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ������ Fire1�� Ŭ���ϸ�
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject go = Instantiate(BulletFactory);
            go.transform.position = firePosition.transform.position;
        }
        // ����Ƽ���� �ҷ� �����޶�� ��û
        // �ҷ��� ��� ������ �뵵�� �°� ���
    }
}
