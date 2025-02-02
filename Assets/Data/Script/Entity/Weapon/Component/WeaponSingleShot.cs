using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSingleShot : SingleShotSkill
{
    //==========================================Variable==========================================
    [Header("Weapon")]
    [SerializeField] private Weapon weapon;
    [SerializeField] private List<WeaponSkillState> triggerableStates;

    //==========================================Get Set===========================================
}
