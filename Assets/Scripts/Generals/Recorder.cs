//using UnityEngine;
//using System.Collections;
//
//public class Recorder : MonoBehaviour {
//    public static Recorder Instance;
//    [HideInInspector]
//    public bool isEnable = false;
//    [HideInInspector]
//    public bool isAvailableVideo = false;
//    void Awake() {
//        Instance = this;
//    }
//
//    void Start()
//    {
////        Everyplay.ReadyForRecording += OnReadyForRecording;
////        Everyplay.UploadDidComplete += OnUploadCompleted;
//    }
//
//    private void OnUploadCompleted(int videoId)
//    {
//        isAvailableVideo = false;
//    }
//
//    public void OnReadyForRecording(bool enabled)
//    {
//        isEnable = enabled;
//    }
//
//    public bool StartRecord()
//    {
//        bool result = false;
//        if (isEnable)
//        {
////            Everyplay.StartRecording();
//            isAvailableVideo = true;
//            result = true;
//        }
//        return result;
//    }
//
//    public bool StopRecord()
//    {
//        bool result = false;
//        if (isEnable && (Everyplay.IsRecording() || Everyplay.IsPaused()))
//        {
//            Everyplay.StopRecording();
//            result = true;
//        }
//        return result;
//    }
//
//    public bool PauseRecord()
//    {
//        bool result = false;
//        if (isEnable && Everyplay.IsRecording())
//        {
//            Everyplay.PauseRecording();
//            result = true;
//        }
//        return result;
//    }
//
//    public bool ResumeRecord()
//    {
//        bool result = false;
//        if (isEnable && Everyplay.IsPaused())
//        {
//            Everyplay.ResumeRecording();
//            result = true;
//        }
//        return result;
//    }
//
//    public bool TakeThumbnail()
//    {
//        bool result = false;
//        if (isEnable)
//        {
//            Everyplay.TakeThumbnail();
//            result = true;
//        }
//        return result;
//    }
//
//    public bool PlayRecord()
//    {
//        bool result = false;
//        if (isEnable)
//        {
//            Everyplay.PlayLastRecording();
//            result = true;
//        }
//        return result;
//    }
//
//    public bool ShareRecord()
//    {
//        bool result = false;
//        if (isEnable)
//        {
//            Everyplay.SetMetadata("name", AllLanguages.notifiTitle[Modules.indexLanguage]);
//            Everyplay.SetMetadata("score", Modules.totalScore);
//            Everyplay.ShowSharingModal();
//            result = true;
//        }
//        return result;
//    }
//
//    public void SetThumbnail(Texture texture) {
//        if (isEnable)
//            Everyplay.SetThumbnailTargetTexture((Texture2D)texture); 
//    }
//}
