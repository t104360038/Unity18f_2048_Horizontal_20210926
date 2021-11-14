using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

/// <summary>
/// �}�l�e�����޲z��
/// �}�l�C���B�]�w�B���}�C��
/// </summary> 
/// �~�����O�N�i�H�s���䦨���A���B�ݩʡB��k


public class MenuManager : MonoBehaviour
{
    // Unity ���s�P�{�����q
    // 1. ���}����k
    // 2. ���s�]�w�I���ƥ� On Click

    // �ϥ� Audio.SetFloat
    public AudioMixer mixer;

    /// <summary>
    /// �}�l�C��
    /// </summary>
    public void StartGame(float delay)
    {
        // �ϥ��~�����O�������y�k:
        // �~�����O����k
        // ��k�W��(�������޼�)
        // ���� delay ���I�s��k
        Invoke("DelayStartGame", delay);
    }

    public void DelayStartGame()
    {
        // �����޲z.���J����(�����W��)
        SceneManager.LoadScene("�C������");
        // SceneManager.LoadScene("1");
    }

    /// <summary>
    /// �]�w�C��
    /// </summary>
    public void SettingGameBGM(float volumn)
    {
        print("BGM�Ʊ쭵�q: " + volumn );
        mixer.SetFloat("���qBGM", volumn);
    }

    /// <summary>
    /// ���}�C��
    /// </summary>
    public void QuitGame(float delay)
    {
        Invoke("DelayQuitGame",delay);
    }
    public void DelayQuitGame()
    {
        // ���ε{��.���}();
        // Quit ���|�b Editor ����A�o�������� ��� PC
        Application.Quit();
        print("���}�C��");
    }
}
