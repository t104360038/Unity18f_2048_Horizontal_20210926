using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

/// <summary>
/// �}�l�e�����޲z��
/// �}�l�C���B�]�w�B���}�C��
/// </summary> 



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
    public void StarGame()
    {
        SceneManager.LoadScene("�C������");
        // SceneManager.LoadScene("0");
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
    public void QuitGame()
    {
        // ���ε{��.���}();
        // Quit ���|�b Editor ����A�o�������� ��� PC
        Application.Quit();
        print("���}�C��");
    }
}
