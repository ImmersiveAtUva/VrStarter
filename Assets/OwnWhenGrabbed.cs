using UnityEngine;
using Normal.Realtime;
using UnityEngine.XR.Interaction.Toolkit;
public class GrabRequest : MonoBehaviour {
    private RealtimeView _realtimeView;
    private RealtimeTransform _realtimeTransform;
    private XRBaseInteractable xrbi;
    public void ownTransform(){
        _realtimeTransform.RequestOwnership();
    }

    private void Awake() {
        _realtimeView = GetComponent<RealtimeView>();
        _realtimeTransform = GetComponent<RealtimeTransform>();
        xrbi = GetComponent<XRGrabInteractable>();
    }
}