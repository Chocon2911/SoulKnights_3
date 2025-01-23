using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : Movement
{
    //===========================================Method===========================================
    protected override void Move()
    {
        this.GetMoveDir();
        base.Move();
    }

    protected virtual void GetMoveDir()
    {
        float angleZ = this.rb.transform.eulerAngles.z;
        float xDir = Mathf.Cos(angleZ * Mathf.Deg2Rad);
        float yDir = Mathf.Sin(angleZ * Mathf.Deg2Rad);
        this.moveDir = new Vector2(xDir, yDir);
    }
}
