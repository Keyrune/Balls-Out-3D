using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectMenu : MonoBehaviour
{
    public PlayerState playerState;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        transform.localPosition = Vector3.zero;
    }

    public void LoadLevel(int levelNum)
    {
        playerState.level = --levelNum;
        playerState.Save();
        //playerState.LevelStart();
        SceneManager.LoadScene(1);
    }
}
