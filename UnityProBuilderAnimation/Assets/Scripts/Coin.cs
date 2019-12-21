using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    #region 屬性
    [Header("金幣音效")]
    public AudioClip clipCoin;
    [Header("喇叭")]
    public AudioSource Aud;
    #endregion


    #region 事件
    // Start is called before the first frame update
    void Start()
    {
        Aud.PlayOneShot(clipCoin);
        Destroy(gameObject,10f);
    }

}
    #endregion

    #region 方法
    #endregion

