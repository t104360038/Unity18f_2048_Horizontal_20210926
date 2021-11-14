using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

/// <summary>
/// 開始畫面選單管理器
/// 開始遊戲、設定、離開遊戲
/// </summary> 



public class MenuManager : MonoBehaviour
{
    // Unity 按鈕與程式溝通
    // 1. 公開的方法
    // 2. 按鈕設定點擊事件 On Click

    // 使用 Audio.SetFloat
    public AudioMixer mixer;

    /// <summary>
    /// 開始遊戲
    /// </summary>
    public void StarGame()
    {
        SceneManager.LoadScene("遊戲場景");
        // SceneManager.LoadScene("0");
    }

    /// <summary>
    /// 設定遊戲
    /// </summary>
    public void SettingGameBGM(float volumn)
    {
        print("BGM滑桿音量: " + volumn );
        mixer.SetFloat("音量BGM", volumn);
    }

    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void QuitGame()
    {
        // 應用程式.離開();
        // Quit 不會在 Editor 執行，發布執行檔 手機 PC
        Application.Quit();
        print("離開遊戲");
    }
}
