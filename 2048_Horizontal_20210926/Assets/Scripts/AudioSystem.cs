using UnityEngine;

/// <summary>
/// ���Ĩt��
/// ���Ѽ��񭵮Ī��\��
/// </summary>
public class AudioSystem : MonoBehaviour
{
    private AudioSource aud;
    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }
    /// <summary>
    /// ���񭵮�
    /// </summary>
    /// <param name="sound"></param>
    public void PlaySound(AudioClip sound)
    {
        aud.PlayOneShot(sound);
    }

    /// <summary>
    /// ���񭵮Ĩ��H�����q 0.8 ~ 1.2
    /// </summary>
    public void PlaySoundWithRandomVolume(AudioClip sound)
    {
        float r = Random.Range(0.8f, 1.2f);
        aud.PlayOneShot(sound, r);
    }
}
