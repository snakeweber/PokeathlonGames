using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pokemon : MonoBehaviour
{
    public int baseSpeed, maxSpeed, basePower, maxPower, baseSkill, maxSkill, baseStam, maxStam, baseJump, maxJump;
    public pokemon(int baseSpeed, int maxSpeed, int basePower, int maxPower, int baseSkill, int maxSkill, int baseStam, int maxStam, int baseJump, int maxJump) {
        baseSpeed = this.baseSpeed;
        maxSpeed = this.maxSpeed;

        basePower = this.basePower;
        maxPower = this.maxPower;

        baseSkill = this.baseSkill;
        maxSkill = this.maxSkill;

        baseStam = this.baseStam;
        maxStam = this.maxStam;

        baseJump = this.baseJump;
        maxJump = this.maxJump;
    }
}
