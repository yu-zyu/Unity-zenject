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

        // 移動
        Move(inputVector, isDash);
    }

    /// <summary>
    /// ジャンプする
    /// </summary>
    void Jump()
    {
        /*
         * 省略 
         */
    }

    /// <summary>
    /// 移動する
    /// </summary>
    /// <param name="direction">移動方向</param>
    /// <param name="isDash">ダッシュするか</param>
    void Move(Vector3 direction, bool isDash)
    {
        /*
         * 省略 
         */
    }
}
