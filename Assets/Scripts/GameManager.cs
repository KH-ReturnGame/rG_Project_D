using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int[] jellyGoldList;
    public Vector3[] PointList;
    
    public runtimeAnimatorController[] LevelAc;

    public void ChangeAc(Animator anim, int level)
    {
        anim.runtimeAnimatorController = LevelAc[level-1];
    }
    
}
