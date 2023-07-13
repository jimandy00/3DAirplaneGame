using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ȭ���� �Ʒ��� �̵�
// �÷��̾� �ѱ�



public class EnemyMove : MonoBehaviour
{
    // �ӵ�
    public float speed = 5f;

    // ����
    Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {

        // �����ϰ� ���ڸ� ������!
        int randomNum = Random.Range(0, 10);
        print(randomNum);
        if (randomNum < 3) // 30% Ȯ�� �̳����
        {
            // �÷��̾� ������Ʈ ã��
            GameObject player = GameObject.Find("Player");
            // �÷��̾� ������Ʈ ������ ���
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

        // �÷��̾� ������Ʈ �ѱ�

         transform.position += dir * speed * Time.deltaTime;
    }
}
