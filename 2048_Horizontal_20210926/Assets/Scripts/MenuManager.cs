using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

/// <summary>
/// 開始畫面選單管理器
/// 開始遊戲、設定、離開遊戲
/// </summary> 
/// 繼承類別就可以存取其成員，欄位、屬性、方法


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
    public void StartGame(float delay)
    {
        // 使用繼承類別的成員語法:
        // 繼承類別的方法
        // 方法名稱(對應的引數)
        // 延遲 delay 秒後呼叫方法
        Invoke("DelayStartGame", delay);
    }

    public void DelayStartGame()
    {
        // 場景管理.載入場景(場景名稱)
        SceneManager.LoadScene("遊戲場景");
        // SceneManager.LoadScene("1");
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
    public void QuitGame(float delay)
    {
        Invoke("DelayQuitGame",delay);
    }
    public void DelayQuitGame()
    {
        // 應用程式.離開();
        // Quit 不會在 Editor 執行，發布執行檔 手機 PC
        Application.Quit();
        print("離開遊戲");
    }
}
