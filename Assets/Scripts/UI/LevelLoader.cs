using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public GameObject Loadingscreen;
    public GameObject loadingobject;

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsyncrounously(sceneIndex));
    }

    IEnumerator LoadAsyncrounously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        Loadingscreen.SetActive(true);

        while(!operation.isDone)
        {
            float progress = 10f;

            //loadingBar.value = progress;
            //PercentLoaded.text = (progress * 100f) + "%";
            loadingobject.transform.Rotate(Vector3.up, progress * Time.deltaTime);

            yield return null;
        }
    }
}
