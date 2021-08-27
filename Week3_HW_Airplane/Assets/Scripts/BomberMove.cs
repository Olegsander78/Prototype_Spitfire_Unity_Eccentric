using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberMove : MonoBehaviour
{
 [Header("Set in Inspector")]
    public Transform BomberTransform;    
    public float BomberSpeed = 50f;
    public float LeftAndRightEdge = 125f;
    bool isForward = true;
    
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //�������� ������� 
        Vector3 pos = transform.position;
        pos.x += BomberSpeed * Time.deltaTime;
        transform.position = pos;
        //����� ����������� �������� ������� �� ���� ������
        if (pos.x < -LeftAndRightEdge)
        {
            BomberSpeed = Mathf.Abs(BomberSpeed);
            isForward = false;
        }
        else
        {
            if( pos.x > LeftAndRightEdge)
            {
                BomberSpeed = -Mathf.Abs(BomberSpeed);
                isForward = false;
            }
        }
        //������� �������� ������� � ����������� �������� (�������� ������ ��������� ������� ������)
        if (isForward)
        {
            transform.Rotate(0f, 180f, 0f);
            isForward = false;
        }
        if (!isForward)
        {
            transform.Rotate(0f, 180f, 0f);
            isForward = true;
        }





    }
}
