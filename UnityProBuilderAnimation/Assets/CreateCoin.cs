using UnityEngine;

public class CreateCoin : MonoBehaviour
{
    [Header("金幣")]
    public GameObject coin;
    [Header("音效")]
    public AudioClip soundCoin;

    private AudioSource aud;

    private void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    /// <summary>
    /// 生成金幣
    /// </summary>
    public void CreateCoinMethod()
    {
        aud.PlayOneShot(soundCoin);
        Instantiate(coin);
    }
}
