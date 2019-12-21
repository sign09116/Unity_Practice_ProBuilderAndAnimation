using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    #region 屬性
    public GameObject gameObj;
    public Transform OBjtransform;
    #endregion
    #region 事件
    // Start is called before the first frame update
    void Start()
    {
        gameObj = Resources.Load<GameObject>("Coin");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
    public void Certate() 
    {
        Instantiate(gameObj, OBjtransform.position, OBjtransform.rotation);
    }
}
