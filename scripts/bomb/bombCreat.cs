using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombCreat : MonoBehaviour
{
    public GameObject bomb;

    // ����� ������ �� �����, ����� ������� � ���������� ����� ������� ��������
    public Transform[] posBombPrefub = new Transform[5];

    Transform location;

   

    void Start()
    {
        InvokeRepeating("creatBomb", 4f, 14f);
        creatBomb();
    }

    // Update is called once per frame
    void Update()
    {
  
      
    }

   void creatBomb()
    {
        
            location = posBombPrefub[Random.Range(0, posBombPrefub.Length)];

            GameObject boom = Instantiate(bomb, location) as GameObject;
        
    }

}
