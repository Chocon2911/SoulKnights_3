using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByKeyboard : Movement
{
    //===========================================Method===========================================
    protected override void Move()
    {
        this.moveDir = InputManager.Instance.MoveDir;
        base.Move();
    }
}
