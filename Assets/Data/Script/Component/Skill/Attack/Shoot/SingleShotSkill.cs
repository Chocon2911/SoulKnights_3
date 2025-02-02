using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleShotSkill : ShootSkill
{
    protected override void UseSkill()
    {
        Vector3 spawnPos = transform.position;
        Quaternion spawnRot = transform.rotation;
        Transform newBulletObj = BulletSpawner.Instance.SpawnByObj(this.bulletObj, spawnPos, spawnRot);

        if (newBulletObj == null) return;
        newBulletObj.gameObject.SetActive(true);
    }
}
