using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ���� �ð��� ������ enemy�� ����



public class EnemySpawn : MonoBehaviour

{

    // enemy ������
    public GameObject enemyFactory;

    // ������ �ð�
    public float createTime = 2f;
    float currentTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���� �ð����� ���� �ð��� ������
        // �ð��� ����
        if(currentTime < createTime)
        {
            currentTime += Time.deltaTime;
        }else
        {
            // ���� �ð��� ����ð����� ���ų� Ŀ���ٸ�
            // ���ʹ̸� ����
            GameObject go = Instantiate(enemyFactory);
            // ����� ���ʹ��� ��ġ�� ���� ��ġ�� ����
            go.transform.position = transform.position;
            // ����ð��� 0���� �ʱ�ȭ
            createTime = Random.Range(2f, 5f);
            // �����ϰ� ����ð��� 2~5�� ���̷� ����
            currentTime = 0;
        }
    }
}
