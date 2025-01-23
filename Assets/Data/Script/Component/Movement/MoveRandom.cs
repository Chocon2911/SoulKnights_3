using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRandom : Movement
{
    //==========================================Variable==========================================
    [Header("Move Random")]
    [SerializeField] protected Vector2 randomPos;
    [SerializeField] protected Vector2 moveZone;

    //==========================================Get Set===========================================
    public Vector2 MoveZone { get => moveZone; set => moveZone = value; }

    //===========================================Unity============================================
    protected virtual void FixedUpdate()
    {
        this.CheckPos();
    }

    //===========================================Method===========================================
    protected virtual void GetRandomPos()
    {
        float xRandom = Random.Range(-this.moveZone.x, this.moveZone.x);
        float yRandom = Random.Range(-this.moveZone.y, this.moveZone.y);

        this.randomPos = new Vector2(xRandom, yRandom);
    }

    protected virtual void CheckPos()
    {
        if (!this.canMove) return;
        float mainObjPosX = this.rb.transform.position.x;
        float mainObjPosY = this.rb.transform.position.y;

        if (Mathf.Abs(mainObjPosX) > Mathf.Abs(randomPos.x) - 0.1f
            && Mathf.Abs(mainObjPosY) > Mathf.Abs(randomPos.y) - 0.1f) this.GetRandomPos();
    }
}
