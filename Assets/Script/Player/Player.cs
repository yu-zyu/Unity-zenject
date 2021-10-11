using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    interface IInputProvider 
    {
        bool GetDash();
        bool GetJump();
        Vector3 GetMoveDirection();
    }
}
