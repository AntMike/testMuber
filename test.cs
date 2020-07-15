
using System;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;

public class test : MonoBehaviour
{
    public bool auth = false;
    public bool restart = false;

    public string email = "";
    public string phone = "";

    [SerializeField] private string AccessKey = "15f50eded083edaa455a8bae1d9da49d4355811a";
    [SerializeField] private string License = "pauseablemubertlicense#v6NWwYmY7HyvBRm2WHhal3rIKFYApxuvudFAyHAmCfiWwzYqxYsp5F4jleWYqYXJDMVNSRQ7PFnr";


    public string pat = "";
    public string AuthToken
    {
        get { pat = PlayerPrefs.GetString("ClientAuthToken", pat); Debug.Log("TOKEN WAS LOADED " + pat); return pat; }
        set { PlayerPrefs.SetString("ClientAuthToken", value); pat = value; Debug.Log("TOKEN WAS SAVED " + value); PlayerPrefs.Save(); }
    }


    public AudioSource audioSource;

    public void Update()
    {
        if (auth)
        {
            auth = false;
            //StartCoroutine(GetServiceAccess());
        }

        if (restart)
        {
            restart = false;
            StartCoroutine(RestartMusic());
        }
    }

    //private IEnumerator GetServiceAccess()
    //{
    //    var request = new WebRequest("https://api-b2b.mubert.com/v2/GetServiceAccess", WebRequest.POST);
    //    {
    //        request.AddParameter("method", "GetServiceAccess");
    //        request.AddParameter("params[email]", email);
    //        request.AddParameter("params[phone]", phone);
    //        request.AddParameter("params[license]", AccessKey);
    //        request.AddParameter("params[token]", License);
    //    }
    //    string user = "";
    //    yield return StartCoroutine(Execute<string>(request, HandleApplyPromoCodeSuccess,
    //            HandleApplyPromoCodeError));









    //    //HTTPRequest request = new HTTPRequest(new Uri("https://api-b2b.mubert.com/v2/GetServiceAccess"), HTTPMethods.Post, (req, resp) => { Debug.Log("fin");
    //    //     Debug.Log(resp.DataAsText);  });
    //    //request.AddField(" \"method\"","\"GetServiceAccess\",\"params\": {\"email\":\"" + email + "\", \"phone\":\"" + phone + "\", \"license\":\"" + AccessKey + "\", \"token\":\"" + License + "\"}");
    //    //request.AddField("params", email);
    //    //request.AddField("email", email);
    //    //request.AddField("phone", phone);
    //    //request.AddField("license", AccessKey );
    //    //request.AddField("token", License); 
    //    //request.Send();
    //}


    void HandleApplyPromoCodeSuccess(string text)
    {
        Debug.Log("suss " + text);
    }

    void HandleApplyPromoCodeError(string text)
    {
        Debug.Log("err " + text);
    }

  




    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    //void Start()
    //{
    //    StartCoroutine(UploadMusic());
    //}

    //void Start()
    //{
    //    StartCoroutine(loadAudio());
    //}
    public static bool Save(string filename, AudioClip clip)
    {
        //if (!filename.ToLower().EndsWith(".mp3"))
        //{
        //    filename += ".mp3";
        //}

        //var filepath = Path.Combine(Application.persistentDataPath, filename);

        //Debug.Log(filepath);

        //// Make sure directory exists if user is saving to sub dir.
        //Directory.CreateDirectory(Path.GetDirectoryName(filepath));

        //using (var fileStream = CreateEmpty(filepath))
        //{

        //    ConvertAndWrite(fileStream, clip);

        //    WriteHeader(fileStream, clip);
        //}


        return true; // TODO: return false if there's a failure saving the file
    }

    private IEnumerator loadAudio()
    {
        var url = "https://ff1.mubert.com/b2b/v2?playlist=0.2.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7";





        //UnityWebRequest webRequest = new UnityWebRequest("https://ff1.mubert.com/b2b/v2?playlist=0.0.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7", "GET");

        //UnityWebRequest music = UnityWebRequestMultimedia.GetAudioClip(url, AudioType.MPEG);


        //ParamsV2 au = new ParamsV2();

        //au.pat = pat;
        //string json = JsonUtility.ToJson(au);

        //json = json.Replace("\"param\":{", "\"params\":{");
        //Debug.Log(json);
        //byte[] encodedPayload = new System.Text.UTF8Encoding().GetBytes(json);
        //music.uploadHandler = (UploadHandler)new UploadHandlerRaw(encodedPayload);
        //music.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();



        //music.SetRequestHeader("Range", "bytes=0-");
        //music.SetRequestHeader("cache-control", "no-cache");
        //webRequest.SetRequestHeader("Content-Type", "application/json");

        //yield return music.SendWebRequest();
        //StringBuilder sb = new StringBuilder();
        //foreach (System.Collections.Generic.KeyValuePair<string, string> dict in music.GetResponseHeaders())
        //{
        //    sb.Append(dict.Key).Append(": \t[").Append(dict.Value).Append("]\n");
        //}


        //Debug.Log(sb.ToString());



        //Debug.Log(music.downloadedBytes);
        //Debug.Log(music.downloadHandler.data.Length);
        //if (music.isNetworkError)
        //{
        //    Debug.Log(music.error);
        //}
        //else
        //{
        //    AudioClip clip = DownloadHandlerAudioClip.GetContent(music);
        //    Debug.Log(clip + " length: " + clip.length);
        //    if (clip)
        //    {
        //        GetComponent<AudioSource>().clip = clip;
        //        GetComponent<AudioSource>().Play();
        //    }
        //}
        //string contentRange = music.GetResponseHeader("Content-Length");
        //Debug.Log("contentRange = " + contentRange + ", bytes = " + music.downloadedBytes.ToString());

        //yield return null;





        //WWW webRequest = new WWW(url);
        //RangeHeader au = new RangeHeader();

        //au.Range = "bytes=0-32";



        //au.method = url;
        //au.param.pat = pat;
        //au.param.playlist = "0.2.0";
        //au.param.intensity = "medium";
        //au.param.bitrate = "128";
        //string json = JsonUtility.ToJson(au);

        //json = json.Replace("\"param\":{", "\"params\":{");
        //Debug.Log(json);
        //byte[] encodedPayload = new System.Text.UTF8Encoding().GetBytes(json);
        //webRequest.uploadHandler = (UploadHandler)new UploadHandlerRaw(encodedPayload);
        //webRequest.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        //webRequest.SetRequestHeader("Content-Type", "application/json");
        //webRequest.SetRequestHeader("cache-control", "no-cache");
        //webRequest.SetRequestHeader("range", "bytes=0-8");

        //yield return webRequest;

        //requestHandel.completed += delegate (AsyncOperation pOperation)
        //{
        //Debug.Log(webRequest.responseCode);

        //Debug.Log(webRequest.bytesDownloaded);
        //};
        //Debug.Log(", bytes = " + webRequest.downloadedBytes.ToString());


        //StringBuilder sb = new StringBuilder();
        //foreach (System.Collections.Generic.KeyValuePair<string, string> dict in webRequest.responseHeaders)
        //{
        //    sb.Append(dict.Key).Append(": \t[").Append(dict.Value).Append("]\n");
        //}

        // Print Headers
        //Debug.Log(sb.ToString());

        // Print Body
        //Debug.Log(webRequest.bytesDownloaded);
        //Debug.Log(webRequest.text.ToString());





        //    var doWeSupportResume = new UnityWebRequest(url, UnityWebRequest.kHttpVerbHEAD);
        //    doWeSupportResume.SetRequestHeader("Range", "bytes=10-20"); //we send a HEAD request with an arbitary value for the Range header, if it returns '206' then resume is supported
        //    doWeSupportResume.Send();

        //    var resumeSupported = doWeSupportResume.responseCode == 206;


        //var    _fileStream = new FileStream(_path + ".temp", FileMode.Append);//make sure we're appending to the existing file
        //  var  resumeOffset = (int)_fileStream.Position;



        //    var rangeHeader = "bytes=" + resumeOffset + "-";//so range is the current filestream position, to infinite (eg. get the rest of the file)
        //    download.SetRequestHeader("Range", rangeHeader);




        //var request = UnityWebRequestMultimedia.GetAudioClip(url, AudioType.MPEG);

        //yield return request.SendWebRequest();

        //UnityWebRequest.

        //if (!request.isHttpError && !request.isNetworkError)
        //{
        //    response(DownloadHandlerAudioClip.GetContent(request));
        //}
        //else
        //{
        //    Debug.LogErrorFormat("error request [{0}, {1}]", url, request.error);

        //    response(null);
        //}

        //request.Dispose();

        //while (true)
        //{
        //    var request = UnityWebRequest.Head(url);
        //    yield return request.SendWebRequest();

        //    Debug.Log(url);
        //    StringBuilder sb = new StringBuilder();
        //    foreach (System.Collections.Generic.KeyValuePair<string, string> dict in request.GetResponseHeaders())
        //    {
        //        sb.Append(dict.Key).Append(": \t[").Append(dict.Value).Append("]\n");
        //    }


        //    Debug.Log(sb.ToString());


        //    Debug.Log(request.downloadedBytes);
        //    Debug.Log(request.responseCode.ToString());


        //    if (!request.isHttpError && !request.isNetworkError)
        //    {
        //        var contentLength = request.GetResponseHeader("Content-Length");
        //        Debug.Log(contentLength);
        //        if (int.TryParse(contentLength, out int returnValue))
        //        {
        //            Debug.Log(returnValue);
        //        }
        //        else
        //        {
        //            Debug.Log(-1);
        //        }
        //    }
        //    else
        //    {
        //        Debug.LogErrorFormat("error request [{0}, {1}]", url, request.error);

        //        Debug.Log(-1);
        //    }

        //    UnityWebRequest webRequest = new UnityWebRequest(url, "POST");
        //    //RangeHeader au = new RangeHeader();
        //    //au.param.pat = pat;
        //    //au.param.playlist = "0.2.0";
        //    //au.method = "GET";
        //    //string json = JsonUtility.ToJson(au);
        //    //json = json.Replace("\"param\":{", "\"params\":{");
        //    //Debug.Log(json);
        //    //byte[] encodedPayload = new System.Text.UTF8Encoding().GetBytes(json);
        //    //webRequest.uploadHandler = (UploadHandler)new UploadHandlerRaw(encodedPayload);
        //    webRequest.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        //    webRequest.SetRequestHeader("Content-Type", "audio/mpeg");
        //    webRequest.SetRequestHeader("cache-control", "no-cache");
        //    //webRequest.SetRequestHeader("Range", "bytes=0-");

        //    UnityWebRequestAsyncOperation requestHandel = webRequest.SendWebRequest();
        //    requestHandel.completed += delegate (AsyncOperation pOperation)
        //    {
        //        Debug.Log(url);
        //        Debug.Log(webRequest.responseCode);
        //        Debug.Log(webRequest.downloadHandler.text);


        //        StringBuilder sb1 = new StringBuilder();
        //        foreach (System.Collections.Generic.KeyValuePair<string, string> dict in request.GetResponseHeaders())
        //        {
        //            sb1.Append(dict.Key).Append(": \t[").Append(dict.Value).Append("]\n");
        //        }


        //        Debug.Log(sb1.ToString());


        //        Debug.Log(webRequest.downloadHandler.data.Length);
        //        Debug.Log(webRequest.downloadedBytes);
        //        Debug.Log(webRequest.responseCode.ToString());


        //        AudioClip ac = webRequest.downloadHandler.data.GetAudioClipCompressed(false, AudioType.MPEG) as AudioClip;

        //    };


        //}

        Hashtable headers = new Hashtable();
        headers.Add("Content-Type", "audio/mpeg");
        //headers.Add("cache-control", "no-cache");

        //ParamsV2 au = new ParamsV2();
        //au.pat = pat;
        //au.playlist = "0.2.0";
        //string json = JsonUtility.ToJson(au);
        //json = json.Replace("\"param\":{", "\"params\":{");
        //Debug.Log(json);
        //byte[] encodedPayload = new System.Text.UTF8Encoding().GetBytes(json);

        //WWWForm form = new WWWForm();

        //form.AddField("Content-Type", "audio/mpeg");
        //form.AddField("Range", "bytes=0-");



        //WWW data = new WWW(url, null, headers);

        //yield return data;
        //Debug.Log(data.url);
        //Debug.Log(data.bytes.Length);
        //Debug.Log(data.bytesDownloaded);
        //Debug.Log(data.text);


        //StringBuilder sb1 = new StringBuilder();
        //foreach (System.Collections.Generic.KeyValuePair<string, string> dict in data.responseHeaders)
        //{
        //    sb1.Append(dict.Key).Append(": \t[").Append(dict.Value).Append("]\n");
        //}


        //Debug.Log(sb1.ToString());

        //while (true)
        //{

        //    UnityWebRequest webRequest = UnityWebRequest("https://ff1.mubert.com/b2b/v2?playlist=0.2.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7");

        //    webRequest.chunkedTransfer = false;

        //    webRequest.SetRequestHeader("Content-Type", "audio/mpeg");
        //    //webRequest.SetRequestHeader("Content-Length", "bytes=0-");
        //    //webRequest.SetRequestHeader("Range", "bytes=0-");


        //    webRequest.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        //webRequest.useHttpContinue = false;

        //    UnityWebRequestAsyncOperation ao = webRequest.SendWebRequest();


        //    StringBuilder sb = new StringBuilder();
        //    foreach (System.Collections.Generic.KeyValuePair<string, string> dict in webRequest.GetResponseHeaders())
        //    {
        //        sb.Append(dict.Key).Append(": \t[").Append(dict.Value).Append("]\n");
        //    }


        //    Debug.Log(sb.ToString());

        //    yield return ao;

        //    if (!webRequest.isHttpError && !webRequest.isNetworkError)
        //    {
        //        var contentLength = webRequest.GetResponseHeader("Content-Length");
        //        Debug.Log(contentLength);
        //    }
        //    else
        //    {
        //        Debug.LogErrorFormat("error request [{0}, {1}]", url, webRequest.error);

        //        Debug.Log(-1);
        //    }
        //    //ao.webRequest.useHttpContinue;

        //    Debug.Log(webRequest.responseCode);
        //    Debug.Log(ao.webRequest.downloadHandler.data.Length);


        //    StringBuilder sb1 = new StringBuilder();
        //    foreach (System.Collections.Generic.KeyValuePair<string, string> dict1 in webRequest.GetResponseHeaders())
        //    {
        //        sb1.Append(dict1.Key).Append(": \t[").Append(dict1.Value).Append("]\n");
        //    }


        //    Debug.Log(sb1.ToString());


        //    Debug.Log(webRequest.downloadHandler.data.Length);
        //    Debug.Log(webRequest.downloadedBytes);
        //    Debug.Log(webRequest.responseCode.ToString());

        //}
        //AudioClip ac = data.GetAudioClipCompressed(false, AudioType.MPEG) as AudioClip;



        //System.Net.HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);

        //myHttpWebRequest.Headers = 
















        yield return null;











        //UnityWebRequest webRequest = UnityWebRequestMultimedia.GetAudioClip(url, AudioType.MPEG);

        //webRequest.SetRequestHeader("Content-Type", "application/json");

        //yield return webRequest.SendWebRequest();

        //if (!webRequest.isNetworkError && !webRequest.isHttpError)
        //{
        //    DownloadHandlerAudioClip dlHandler = (DownloadHandlerAudioClip)webRequest.downloadHandler;
        //    if (dlHandler.isDone)
        //    {
        //        AudioClip audioClip = dlHandler.audioClip;

        //        if (audioClip != null)
        //        {
        //            //_audioCacheManager.Add(job.Key, audioClip);
        //            //Save("clip", audioClip);
        //            audioSource.clip = audioClip;

        //        }
        //        else
        //        {
        //            Debug.Log("Retrieved AudioClip is null.");
        //        }
        //    }
        //    else
        //    {
        //        Debug.Log("The download process is not completely finished.");
        //    }
        //}
        //else
        //{
        //    Debug.Log(webRequest.error);
        //}
    }





    IEnumerator GetAudioClip()
    {
        var url = "https://ff1.mubert.com/b2b/v2?playlist=0.0.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7";
        //WWW www = new WWW("https://ff1.mubert.com/b2b/v2?playlist=0.0.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7");

        while (true)
        {

            //WWW data = new WWW(url);
            //yield return data;

            //StringBuilder sb = new StringBuilder();
            //foreach (System.Collections.Generic.KeyValuePair<string, string> dict in data.responseHeaders)
            //{
            //    sb.Append(dict.Key).Append(": \t[").Append(dict.Value).Append("]\n");
            //}

            //// Print Headers
            //Debug.Log(sb.ToString());

            //// Print Body
            //Debug.Log(data.bytesDownloaded);
            //Debug.Log(data.text.ToString());

            string googleUrl = "https://ff1.mubert.com/b2b/v2?playlist=0.0.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7" ;

            WWW www = new WWW(url);
           
            yield return www;
            audioSource.clip = www.GetAudioClip(false, true, AudioType.MPEG);



        }
    }

    IEnumerator UploadMusic()
    {
        UnityWebRequest webRequest = new UnityWebRequest("https://ff1.mubert.com/b2b/v2?playlist=0.0.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7", "GET");

        webRequest.SetRequestHeader("bytes", "0");

        UnityWebRequestAsyncOperation requestHandel = webRequest.SendWebRequest();
        requestHandel.completed += delegate (AsyncOperation pOperation)
        {
            Debug.Log(webRequest.responseCode);
            Debug.Log(webRequest.downloadHandler.text);
        };

        yield return null;
    }



    IEnumerator UpdateMusic()
    {
        UnityWebRequest webRequest = new UnityWebRequest("https://api-b2b.mubert.com/v2/GetPlayMusic", "POST");
        Method au = new Method();
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
        requestHandel.completed += delegate (AsyncOperation pOperation)
        {
            Debug.Log(webRequest.responseCode);
            Debug.Log(webRequest.downloadHandler.text);
        };

        yield return null;

        /*
         * {"method":"GetPlayMusic","status":1,"data":{"available_bitrates":[{"bitrate":32},{"bitrate":96},{"bitrate":128},{"bitrate":192},{"bitrate":256},{"bitrate":320}],
         * "available_intensities":[{"intensity":"low"},{"intensity":"medium"},{"intensity":"high"}],
         * "categories":[{"category_id":0,"name":"Moods","playlist":"0","groups":[
         * {"group_id":0,"name":"Calm","playlist":"0.0","channels":[
         * {"channel_id":0,"name":"Calm","playlist":"0.0.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.0.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":1,"name":"Acoustic","playlist":"0.0.1","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.0.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":1,"name":"Energizing","playlist":"0.1","channels":[{"channel_id":0,"name":"Pumped","playlist":"0.1.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.1.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":1,"name":"Groovy","playlist":"0.1.1","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.1.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":2,"name":"Upbeat","playlist":"0.1.2","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.1.2&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":3,"name":"Night","playlist":"0.1.3","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.1.3&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":4,"name":"Extreme","playlist":"0.1.4","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.1.4&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":5,"name":"Motivation","playlist":"0.1.5","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.1.5&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":2,"name":"Joyful","playlist":"0.2","channels":[{"channel_id":0,"name":"Happy","playlist":"0.2.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.2.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":1,"name":"Optimistic","playlist":"0.2.1","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.2.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.2&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":3,"name":"Sad","playlist":"0.3","channels":[{"channel_id":0,"name":"Sad","playlist":"0.3.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.3.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":1,"name":"Sentimental","playlist":"0.3.1","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.3.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.3&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":4,"name":"Tense","playlist":"0.4","channels":[{"channel_id":0,"name":"Serious","playlist":"0.4.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.4.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":1,"name":"Dramatic","playlist":"0.4.1","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.4.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.4&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":5,"name":"Beautiful","playlist":"0.5","channels":[{"channel_id":0,"name":"Beautiful","playlist":"0.5.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.5.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":1,"name":"Peaceful","playlist":"0.5.1","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.5.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":2,"name":"Friends","playlist":"0.5.2","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.5.2&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":3,"name":"Gentle","playlist":"0.5.3","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.5.3&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.5&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":6,"name":"Erotic","playlist":"0.6","channels":[{"channel_id":0,"name":"Romantic","playlist":"0.6.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.6.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.6&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":7,"name":"Dreamy","playlist":"0.7","channels":[{"channel_id":0,"name":"Dreamy","playlist":"0.7.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.7.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.7&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":8,"name":"Heroic","playlist":"0.8","channels":[{"channel_id":0,"name":"Epic","playlist":"0.8.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.8.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.8&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":10,"name":"Scary","playlist":"0.10","channels":[{"channel_id":0,"name":"Spooky","playlist":"0.10.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.10.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.10&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"category_id":1,"name":"Focus","playlist":"1","groups":[{"group_id":0,"name":"Minimal","playlist":"1.0","channels":[{"channel_id":0,"name":"Minimal 120","playlist":"1.0.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=1.0.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":1,"name":"Minimal 170","playlist":"1.0.1","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=1.0.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=1.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"category_id":2,"name":"Sleep","playlist":"2","groups":[{"group_id":0,"name":"Ambient","playlist":"2.0","channels":[{"channel_id":0,"name":"Ambient","playlist":"2.0.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=2.0.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=2.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":1,"name":"Classical","playlist":"2.1","channels":[{"channel_id":0,"name":"Piano","playlist":"2.1.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=2.1.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=2.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":2,"name":"Lullaby","playlist":"2.2","channels":[{"channel_id":0,"name":"Lullaby","playlist":"2.2.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=2.2.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=2.2&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=2&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"category_id":3,"name":"Calm","playlist":"3","groups":[{"group_id":0,"name":"Ambient","playlist":"3.0","channels":[{"channel_id":0,"name":"Meditation","playlist":"3.0.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=3.0.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":1,"name":"Om","playlist":"3.0.1","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=3.0.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":2,"name":"Zen","playlist":"3.0.2","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=3.0.2&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=3.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":1,"name":"Chill","playlist":"3.1","channels":[{"channel_id":0,"name":"Beautiful","playlist":"3.1.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=3.1.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=3.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=3&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"category_id":4,"name":"Chill","playlist":"4","groups":[{"group_id":0,"name":"Chillout","playlist":"4.0","channels":[{"channel_id":0,"name":"Chillout","playlist":"4.0.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=4.0.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":1,"name":"Romantic","playlist":"4.0.1","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=4.0.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=4.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":1,"name":"Ethnic","playlist":"4.1","channels":[{"channel_id":0,"name":"Ethnic 108","playlist":"4.1.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=4.1.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=4.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":2,"name":"Summer","playlist":"4.2","channels":[{"channel
         * 
         * */
    }


    IEnumerator RestartMusic()
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
        requestHandel.completed += delegate (AsyncOperation pOperation)
        {
            Debug.Log(webRequest.responseCode);
            Debug.Log(webRequest.downloadHandler.text);
        };

        yield return null;

        /*
         * {"method":"GetPlayMusic","status":1,"data":{"available_bitrates":[{"bitrate":32},{"bitrate":96},{"bitrate":128},{"bitrate":192},{"bitrate":256},{"bitrate":320}],
         * "available_intensities":[{"intensity":"low"},{"intensity":"medium"},{"intensity":"high"}],
         * "categories":[{"category_id":0,"name":"Moods","playlist":"0","groups":[
         * {"group_id":0,"name":"Calm","playlist":"0.0","channels":[
         * {"channel_id":0,"name":"Calm","playlist":"0.0.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.0.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":1,"name":"Acoustic","playlist":"0.0.1","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.0.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":1,"name":"Energizing","playlist":"0.1","channels":[{"channel_id":0,"name":"Pumped","playlist":"0.1.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.1.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":1,"name":"Groovy","playlist":"0.1.1","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.1.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":2,"name":"Upbeat","playlist":"0.1.2","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.1.2&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":3,"name":"Night","playlist":"0.1.3","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.1.3&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":4,"name":"Extreme","playlist":"0.1.4","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.1.4&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":5,"name":"Motivation","playlist":"0.1.5","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.1.5&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":2,"name":"Joyful","playlist":"0.2","channels":[{"channel_id":0,"name":"Happy","playlist":"0.2.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.2.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":1,"name":"Optimistic","playlist":"0.2.1","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.2.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.2&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":3,"name":"Sad","playlist":"0.3","channels":[{"channel_id":0,"name":"Sad","playlist":"0.3.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.3.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":1,"name":"Sentimental","playlist":"0.3.1","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.3.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.3&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":4,"name":"Tense","playlist":"0.4","channels":[{"channel_id":0,"name":"Serious","playlist":"0.4.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.4.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":1,"name":"Dramatic","playlist":"0.4.1","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.4.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.4&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":5,"name":"Beautiful","playlist":"0.5","channels":[{"channel_id":0,"name":"Beautiful","playlist":"0.5.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.5.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":1,"name":"Peaceful","playlist":"0.5.1","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.5.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":2,"name":"Friends","playlist":"0.5.2","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.5.2&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":3,"name":"Gentle","playlist":"0.5.3","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.5.3&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.5&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":6,"name":"Erotic","playlist":"0.6","channels":[{"channel_id":0,"name":"Romantic","playlist":"0.6.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.6.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.6&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":7,"name":"Dreamy","playlist":"0.7","channels":[{"channel_id":0,"name":"Dreamy","playlist":"0.7.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.7.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.7&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":8,"name":"Heroic","playlist":"0.8","channels":[{"channel_id":0,"name":"Epic","playlist":"0.8.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.8.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.8&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":10,"name":"Scary","playlist":"0.10","channels":[{"channel_id":0,"name":"Spooky","playlist":"0.10.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.10.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0.10&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"category_id":1,"name":"Focus","playlist":"1","groups":[{"group_id":0,"name":"Minimal","playlist":"1.0","channels":[{"channel_id":0,"name":"Minimal 120","playlist":"1.0.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=1.0.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":1,"name":"Minimal 170","playlist":"1.0.1","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=1.0.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=1.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"category_id":2,"name":"Sleep","playlist":"2","groups":[{"group_id":0,"name":"Ambient","playlist":"2.0","channels":[{"channel_id":0,"name":"Ambient","playlist":"2.0.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=2.0.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=2.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":1,"name":"Classical","playlist":"2.1","channels":[{"channel_id":0,"name":"Piano","playlist":"2.1.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=2.1.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=2.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":2,"name":"Lullaby","playlist":"2.2","channels":[{"channel_id":0,"name":"Lullaby","playlist":"2.2.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=2.2.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=2.2&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=2&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"category_id":3,"name":"Calm","playlist":"3","groups":[{"group_id":0,"name":"Ambient","playlist":"3.0","channels":[{"channel_id":0,"name":"Meditation","playlist":"3.0.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=3.0.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":1,"name":"Om","playlist":"3.0.1","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=3.0.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":2,"name":"Zen","playlist":"3.0.2","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=3.0.2&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=3.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":1,"name":"Chill","playlist":"3.1","channels":[{"channel_id":0,"name":"Beautiful","playlist":"3.1.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=3.1.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=3.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=3&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"category_id":4,"name":"Chill","playlist":"4","groups":[{"group_id":0,"name":"Chillout","playlist":"4.0","channels":[{"channel_id":0,"name":"Chillout","playlist":"4.0.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=4.0.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"channel_id":1,"name":"Romantic","playlist":"4.0.1","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=4.0.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=4.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":1,"name":"Ethnic","playlist":"4.1","channels":[{"channel_id":0,"name":"Ethnic 108","playlist":"4.1.0","emoji":"","icon":"","stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=4.1.0&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}}],"stream":{"url":"https://ff1.mubert.com/b2b/v2?playlist=4.1&pat=cGF1c2VhYmxlLjE5Mjc5Ny4xNWY1MGVkZWQwODNlZGFhNDU1YThiYWUxZDlkYTQ5ZDQzNTU4MTFhLjEuMg.d97d2b749e312e09e6f9903976ff032c15c76baf45fe49a1e09b1f42041100d7"}},{"group_id":2,"name":"Summer","playlist":"4.2","channels":[{"channel
         * 
         * */
    }




    //IEnumerator Upload()
    //{
    //    List<IMultipartFormSection> formData = new List<IMultipartFormSection>();

    //    formData.Add(new MultipartFormDataSection(" \"method\":\"GetServiceAccess\",\"params\": {\"email\":\""+email+"\", \"phone\":\""+phone+"\", \"license\":\""+ AccessKey + "\", \"token\":\""+ License + "\"}"));
    //    //formData.Add(new MultipartFormDataSection("method", "GetServiceAccess"));
    //    //formData.Add(new MultipartFormFileSection("params", "{\"email\":\""+email+ "\",\"phone\":\"" + phone + "\",\"license\":\"" + AccessKey + "\",\"token\":\"" + License + "\"}"));

    //    UnityWebRequest www = UnityWebRequest.Post("https://api-b2b.mubert.com/v2/GetServiceAccess", formData);
    //    www.method = "POST";
    //    Debug.Log(www.method );
    //    yield return www.SendWebRequest();

    //    if (www.isNetworkError || www.isHttpError)
    //    {
    //        Debug.Log(www.error);
    //    }
    //    else
    //    {
    //        Debug.Log("Form upload complete! ");
    //        Debug.Log(www.error);
    //        Debug.Log(www.responseCode);
    //        StringBuilder sb = new StringBuilder();
    //        foreach (System.Collections.Generic.KeyValuePair<string, string> dict in www.GetResponseHeaders())
    //        {
    //            sb.Append(dict.Key).Append(": \t[").Append(dict.Value).Append("]\n");
    //        }

    //        // Print Headers
    //        Debug.Log(sb.ToString());

    //        // Print Body
    //        Debug.Log(www.downloadHandler.text);
    //    }
    //}


    IEnumerator Upload()
    {
        WWWForm form = new WWWForm();
        //form.AddField("method", "GetServiceAccess");
        //form.AddField("params[email]", email);
        //form.AddField("params[phone]", phone);
        //form.AddField("params[license]", AccessKey);
        //form.AddField("params[token]", License);






        UnityWebRequest webRequest = new UnityWebRequest("https://api-b2b.mubert.com/v2/GetServiceAccess", "POST");
        Auth au = new Auth();
        au.param.email = email;
        au.param.phone = phone;
        au.param.license = AccessKey;
        au.param.token = License;
        string json = JsonUtility.ToJson(au);
        json = json.Replace("\"param\":{", "\"params\":{");
        Debug.Log(json);
        byte[] encodedPayload = new System.Text.UTF8Encoding().GetBytes(json);
        webRequest.uploadHandler = (UploadHandler)new UploadHandlerRaw(encodedPayload);
        webRequest.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        webRequest.SetRequestHeader("Content-Type", "application/json");
        webRequest.SetRequestHeader("cache-control", "no-cache");

        UnityWebRequestAsyncOperation requestHandel = webRequest.SendWebRequest();
        requestHandel.completed += delegate (AsyncOperation pOperation)
        {
            Debug.Log(webRequest.responseCode);
            Debug.Log(webRequest.downloadHandler.text);
        };

        //request.AddField("params", email);
        //request.AddField("email", email);
        //request.AddField("phone", phone);
        //request.AddField("license", AccessKey );
        //request.AddField("token", License); 

        //using (UnityWebRequest www = UnityWebRequest.Post("https://api-b2b.mubert.com/v2/GetServiceAccess", form))
        //{
        //    yield return www.SendWebRequest();

        //    Debug.Log(Convert.ToBase64String(www.uploadHandler.data));

        //    if (www.isNetworkError || www.isHttpError)
        //    {
        //        Debug.Log(www.error);
        //    }
        //    else
        //    {
        //        Debug.Log("Form upload complete!");
        //        StringBuilder sb = new StringBuilder();
        //        foreach (System.Collections.Generic.KeyValuePair<string, string> dict in www.GetResponseHeaders())
        //        {
        //            sb.Append(dict.Key).Append(": \t[").Append(dict.Value).Append("]\n");
        //        }

        //        // Print Headers
        //        Debug.Log(sb.ToString());

        //        // Print Body
        //        Debug.Log(www.downloadHandler.text);
        //    }
        //}

        yield return null;
    }

    static FileStream CreateEmpty(string filepath)
    {
        var fileStream = new FileStream(filepath, FileMode.Create);
        byte emptyByte = new byte();

        for (int i = 0; i < 44; i++) //preparing the header
        {
            fileStream.WriteByte(emptyByte);
        }

        return fileStream;
    }

    static void ConvertAndWrite(FileStream fileStream, AudioClip clip)
    {

        var samples = new float[clip.samples];

        clip.GetData(samples, 0);

        Int16[] intData = new Int16[samples.Length];
        //converting in 2 float[] steps to Int16[], //then Int16[] to Byte[]

        Byte[] bytesData = new Byte[samples.Length * 2];
        //bytesData array is twice the size of
        //dataSource array because a float converted in Int16 is 2 bytes.

        int rescaleFactor = 32767; //to convert float to Int16

        for (int i = 0; i < samples.Length; i++)
        {
            intData[i] = (short)(samples[i] * rescaleFactor);
            Byte[] byteArr = new Byte[2];
            byteArr = BitConverter.GetBytes(intData[i]);
            byteArr.CopyTo(bytesData, i * 2);
        }

        fileStream.Write(bytesData, 0, bytesData.Length);
    }

    static void WriteHeader(FileStream fileStream, AudioClip clip)
    {

        var hz = clip.frequency;
        var channels = clip.channels;
        var samples = clip.samples;

        fileStream.Seek(0, SeekOrigin.Begin);

        Byte[] riff = System.Text.Encoding.UTF8.GetBytes("RIFF");
        fileStream.Write(riff, 0, 4);

        Byte[] chunkSize = BitConverter.GetBytes(fileStream.Length - 8);
        fileStream.Write(chunkSize, 0, 4);

        Byte[] wave = System.Text.Encoding.UTF8.GetBytes("WAVE");
        fileStream.Write(wave, 0, 4);

        Byte[] fmt = System.Text.Encoding.UTF8.GetBytes("fmt ");
        fileStream.Write(fmt, 0, 4);

        Byte[] subChunk1 = BitConverter.GetBytes(16);
        fileStream.Write(subChunk1, 0, 4);

        UInt16 two = 2;
        UInt16 one = 1;

        Byte[] audioFormat = BitConverter.GetBytes(one);
        fileStream.Write(audioFormat, 0, 2);

        Byte[] numChannels = BitConverter.GetBytes(channels);
        fileStream.Write(numChannels, 0, 2);

        Byte[] sampleRate = BitConverter.GetBytes(hz);
        fileStream.Write(sampleRate, 0, 4);

        Byte[] byteRate = BitConverter.GetBytes(hz * channels * 2); // sampleRate * bytesPerSample*number of channels, here 44100*2*2
        fileStream.Write(byteRate, 0, 4);

        UInt16 blockAlign = (ushort)(channels * 2);
        fileStream.Write(BitConverter.GetBytes(blockAlign), 0, 2);

        UInt16 bps = 16;
        Byte[] bitsPerSample = BitConverter.GetBytes(bps);
        fileStream.Write(bitsPerSample, 0, 2);

        Byte[] datastring = System.Text.Encoding.UTF8.GetBytes("data");
        fileStream.Write(datastring, 0, 4);

        Byte[] subChunk2 = BitConverter.GetBytes(samples * channels * 2);
        fileStream.Write(subChunk2, 0, 4);

        //		fileStream.Close();
    }

}

public class Auth
{
    public string method = "GetServiceAccess";
    public Params param = new Params();
}


public class Method
{
    public string method = "GetPlayMusic";
    public ParamsPat param = new ParamsPat();
}

[System.Serializable]
public class Params
{
    public string email = "address@domain.domain";
    public string phone = "+11234567890";
    public string license = "15f50eded083edaa455a8bae1d9da49d4355811a";
    public string token = "pauseablemubertlicense#v6NWwYmY7HyvBRm2WHhal3rIKFYApxuvudFAyHAmCfiWwzYqxYsp5F4jleWYqYXJDMVNSRQ7PFnr";
}

[System.Serializable]
public class ParamsPat
{
    public string pat = "";
}


[System.Serializable]
public class RangeHeader
{
    public string method = "GetServiceAccess";
    //public string Range = "";

    public ParamsV2 param = new ParamsV2();
}

[System.Serializable]
public class ParamsV2
{
    public string playlist = "0.2.0";
    public string pat = "+11234567890";
    public string bitrate = "128";
    public string intensity = "medium";
}