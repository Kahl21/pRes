using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public GameObject Loadingscreen;
    public GameObject loadingobject;
    float spin;
    private bool loading = true;

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsyncrounously(sceneIndex));
    }

    IEnumerator LoadAsyncrounously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex, LoadSceneMode.Single);

        Loadingscreen.SetActive(true);

        loading = true;

        while(!operation.isDone)
       {
            //float progress = 10f;
            //spin = loadingobject.GetComponent<RectTransform>().rotation.z;

            //loadingBar.value = progress;
            //PercentLoaded.text = (progress * 100f) + "%";
            //loadingobject.transform.Rotate(Vector3.up, progress * Time.deltaTime);
            //loadingobject.GetComponent<RectTransform>().Rotate(new Vector3(0,0,spin+10));

            yield return null;
       }
        
    }

    public void Update()
    {
        Debug.Log(loading);

        if (loading)
        {
            spin = loadingobject.GetComponent<RectTransform>().rotation.z;
            loadingobject.GetComponent<RectTransform>().Rotate(new Vector3(0,0,spin+10));
            loading = true;
        }

        }

}
