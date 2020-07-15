using System;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using UnityEngine.UI;
using UMP;


public class AudioController : MonoBehaviour
{

    public static AudioController Instance;


    public UniversalMediaPlayer UMP;

    public string email = "address@domain.domain";
    public string phone = "+11234567890";

    [SerializeField] private string AccessKey = "pauseablemubertlicense#v6NWwYmY7HyvBRm2WHhal3rIKFYApxuvudFAyHAmCfiWwzYqxYsp5F4jleWYqYXJDMVNSRQ7PFnr";
    [SerializeField] private string License = "15f50eded083edaa455a8bae1d9da49d4355811a";


    public string pat = "cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7";
    public string AuthToken
    {
        get { pat = PlayerPrefs.GetString("ClientAuthToken", pat); Debug.Log("TOKEN WAS LOADED " + pat); return pat; }
        set { PlayerPrefs.SetString("ClientAuthToken", value); pat = value; Debug.Log("TOKEN WAS SAVED " + value); PlayerPrefs.Save(); }
    }



    public AudioSource audioSource;
    public AudioSource offlineAudioSource;
    public AudioClip defaultClip;
    public Text debug;
    public Sprite defaultBtnSpr;
    public Sprite activeBtnSpr;
    public Image playBtn;
    public bool isOnline = false;
    public bool isPlaySprite = false;
    public Sprite playSpr;
    public Sprite rebutSpr;
    public Button relax;
    public Button calm;
    public Button energize;
    public bool isRelax = false;
    public bool isCalm = false;
    public bool isEnergize = false;
    public string relaxURL = "https://ff1.mubert.com/b2b/v2?playlist=4.0.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7";
    public string calmURL = "https://ff1.mubert.com/b2b/v2?playlist=0.0.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7";
    public string energizeURL = "https://ff1.mubert.com/b2b/v2?playlist=0.1.5&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7";

    private bool isFadeDown = false;
    private bool isFadeIn = false;
    public float defFadeTime = 2f;
    private float fadeTime = -1f;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    private void Update()
    {
        OnlineAudioConroller();

        if (isFadeDown)
        {
            FadeControll();
        }

        if(fadeTime >= 0)
        {
            DoFade();
        }
    }

    private void OnlineAudioConroller()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            if (isOnline || !isOnline && debug.text == ("You're offline"))
            {
                isOnline = false;
                isRelax = false;
                isCalm = false;
                isEnergize = false;
                isPlaySprite = true;
                playBtn.sprite = playSpr;
                debug.text = ("You're offline");
                UMP.Stop();
                audioSource.Stop();
                if (offlineAudioSource.clip != defaultClip)
                    offlineAudioSource.clip = defaultClip;
                if (!offlineAudioSource.isPlaying)
                    offlineAudioSource.Play();
            }
        }
        else
        {
            if (!isOnline)
            {
                isOnline = true;
                debug.text = "";

            }
            if (!audioSource.isPlaying)
            {
                if (isRelax)
                {
                    if (offlineAudioSource.isPlaying)
                        offlineAudioSource.Stop();
                    UMP.Path = relaxURL;
                    UMP.Play();
                }
                else if (isCalm)
                {
                    if (offlineAudioSource.isPlaying)
                        offlineAudioSource.Stop();
                    UMP.Path = calmURL;
                    UMP.Play();
                }
                else if (isEnergize)
                {
                    if (offlineAudioSource.isPlaying)
                        offlineAudioSource.Stop();
                    UMP.Path = energizeURL;
                    UMP.Play();
                }
            }
        }
    }

    private void FadeControll()
    {
        float volume = UMP.Volume;
        volume += isFadeIn ? 1 : -1;
        if (volume < 0)
            volume = 0;
        else if (volume > 100)
            volume = 100;
        UMP.Volume = volume;
        audioSource.volume = volume / 100;
        offlineAudioSource.volume = volume / 100;

    }

    public void BtbStartFade(bool isFadeIn)
    {
        this.isFadeIn = isFadeIn;
        fadeTime = defFadeTime;
    }

    public void DoFade()
    {
        float volume = UMP.Volume;
        float time = 1 - (fadeTime / defFadeTime);
        volume = isFadeIn ? time*100: (1- time)*100;
        if (volume < 0)
            volume = 0;
        else if (volume > 100)
            volume = 100;
        UMP.Volume = volume;
        audioSource.volume = volume / 100;
        offlineAudioSource.volume = volume / 100;
        fadeTime -= Time.deltaTime;
    }


    public void BtnRelax()
    {
        if (offlineAudioSource.isPlaying)
            offlineAudioSource.Stop();
        isPlaySprite = false;
        playBtn.sprite = rebutSpr;
        isCalm = false;
        isEnergize = false;
        isRelax = true;

        relax.image.sprite = activeBtnSpr;
        calm.image.sprite = defaultBtnSpr;
        energize.image.sprite = defaultBtnSpr;

        UMP.Path = relaxURL;
        UMP.Play();
        playBtn.sprite = rebutSpr;
    }

    public void BtnCalm()
    {
        if (offlineAudioSource.isPlaying)
            offlineAudioSource.Stop();
        isPlaySprite = false;
        playBtn.sprite = rebutSpr;
        isCalm = true;
        isEnergize = false;
        isRelax = false;

        relax.image.sprite = defaultBtnSpr;
        calm.image.sprite = activeBtnSpr;
        energize.image.sprite = defaultBtnSpr;

        UMP.Path = calmURL;
        UMP.Play();
        playBtn.sprite = rebutSpr;
    }

    public void BtnEnergize()
    {
        if (offlineAudioSource.isPlaying)
            offlineAudioSource.Stop();
        isPlaySprite = false;
        playBtn.sprite = rebutSpr;
        isCalm = false;
        isEnergize = true;
        isRelax = false;

        relax.image.sprite = defaultBtnSpr;
        calm.image.sprite = defaultBtnSpr;
        energize.image.sprite = activeBtnSpr;

        UMP.Path = energizeURL;
        UMP.Play();
        playBtn.sprite = rebutSpr;
    }


    public void BtnPlay()
    {
        if(isOnline)
        {
            if(isPlaySprite)
            {
                BtnRelax();
            } else
            {
                RestartGeneration();
            }
        } else
        {

        }
    }

    public void RestartGeneration()
    {
        StartCoroutine(RestartMusic());
    }

    public void BtnFadeIn(bool isDown)
    {
        isFadeDown = isDown;
        if(isDown)
        isFadeIn = true;
    }

    public void BtnFadeOut(bool isDown)
    {
        isFadeDown = isDown;
        if (isDown)
            isFadeIn = false;
    }

    private IEnumerator RestartMusic()
    {
        UnityWebRequest webRequest = new UnityWebRequest("https://api-b2b.mubert.com/v2/Restart", "POST");
        Method au = new Method();
        au.method = "Restart";
        au.param.pat = pat;
        string json = JsonUtility.ToJson(au);
        json = json.Replace("\"param\":{", "\"params\":{");
        Debug.Log(json);
        byte[] encodedPayload = new System.Text.UTF8Encoding().GetBytes(json);
        webRequest.uploadHandler = (UploadHandler)new UploadHandlerRaw(encodedPayload);
        webRequest.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        webRequest.SetRequestHeader("Content-Type", "application/json");
        webRequest.SetRequestHeader("cache-control", "no-cache");

        UnityWebRequestAsyncOperation requestHandel = webRequest.SendWebRequest();
        int time = 0;
        requestHandel.completed += delegate (AsyncOperation pOperation)
        {
            Debug.Log(webRequest.responseCode);
            Debug.Log(webRequest.downloadHandler.text);
            if(webRequest.downloadHandler.text.Contains("Will be restarted"))
            {
                Restart responce = JsonUtility.FromJson<Restart>(webRequest.downloadHandler.text);

                debug.text = responce.data.text + " in 5 sec";
                StartCoroutine(ClearDebug(5));
            }
            //{"method":"Restart","status":1,"data":{"code":1,"text":"Will be restarted","time":31},"api_ver":"api-b2b_2.1"}
        };
        yield return null;
    }

    private IEnumerator ClearDebug(float time)
    {
        yield return new WaitForSeconds(time);
        debug.text = "";
    }

}

public class Method
{
    public string method = "GetPlayMusic";
    public ParamsPat param = new ParamsPat();
}

[System.Serializable]
public class ParamsPat
{
    public string pat = "";
}

public class Restart
{
    public string method = "GetPlayMusic";
    public string status = "GetPlayMusic";
    public Data data = new Data();
}

[System.Serializable]
public class Data
{
    public string code = "";
    public string text = "";
    public string time = "";
}
