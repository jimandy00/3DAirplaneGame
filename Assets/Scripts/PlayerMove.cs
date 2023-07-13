using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// �����(����) �Է¿� ����
// �÷��̾ �̵���Ű�� �ʹ�!


public class PlayerMove : MonoBehaviour
{
    // �ӵ��� ������ �� �ִ� ��������
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ����� �Է��� �޾ƿ���
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // ���� ����
        Vector3 dir = new Vector3(h, v, 0);
        // ���� �ӵ� �����ϰ� ���ֱ�
        dir.Normalize();
        // ������ ���⿡ ���缭 ������Ʈ �̵�
        // p = p0 + vt
        // transform.position = transform.position + dir * speed * Time.deltaTime;
        transform.position += dir * speed * Time.deltaTime;
        
    }
}
