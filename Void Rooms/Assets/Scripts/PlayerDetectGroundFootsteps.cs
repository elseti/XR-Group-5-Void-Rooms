using UnityEngine;

namespace DefaultNamespace
{
    public class PlayerDetectGroundFootsteps : MonoBehaviour
    {
        private void OnTriggerEnter(Collider col)
        {
            print("on trigger");
            if (col.gameObject.CompareTag("Ground"))
            {
                print("on ground PlayerDetectGroundFootsteps");
                GameManager.instance.gameObject.GetComponent<PlayerFootsteps>().onWater = false;
            }
            else if(col.gameObject.CompareTag("Water"))
            {
                print("water PlayerDetectGroundFootsteps");
                GameManager.instance.gameObject.GetComponent<PlayerFootsteps>().onWater = true;
            }
        }
    }
}