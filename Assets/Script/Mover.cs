using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Mover : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            Jump();
        }

        var inputVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        var isDash = Input.GetButton("Dash");

        // �ړ�
        Move(inputVector, isDash);
    }

    /// <summary>
    /// �W�����v����
    /// </summary>
    void Jump()
    {
        /*
         * �ȗ� 
         */
    }

    /// <summary>
    /// �ړ�����
    /// </summary>
    /// <param name="direction">�ړ�����</param>
    /// <param name="isDash">�_�b�V�����邩</param>
    void Move(Vector3 direction, bool isDash)
    {
        /*
         * �ȗ� 
         */
    }
}
