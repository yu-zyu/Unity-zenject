using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InputProviders
{
    public class UnityInputProvider : IInputProvider 
    {
        public bool GetDash()
        {
            return Input.GetButton("Dash");
        }

        public bool GetJump()
        {
            return Input.GetButton("Jump");
        }

        public Vector3 GetMoveDirection()
        {
            return new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        }
    }
}