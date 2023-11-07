using UnityEngine;

public class TelephoneSilence : MonoBehaviour
{
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        // GameManager.instance.PlaySFX("phoneHangup");
        
    }

    private void OnTriggerExit()
    {
        // GameManager.instance.StopSFX();
    }
}
