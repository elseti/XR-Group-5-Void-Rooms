using UnityEngine;

namespace Level_2.Piano_Keys
{
    public class CHighInteractable : IInteractable
    {
        private AudioSource audioSource;
        
        private void Start()
        {
            audioSource = this.gameObject.GetComponent<AudioSource>();
        }
        
        public void OnSelectEnter()
        {
            this.transform.parent.GetComponent<Animator>().Play("L2 Piano C6");
            audioSource.PlayOneShot(GameManager.instance.GetSFX("pianoCHigh"));
            PianoManager.instance.PressNote("chigh");
        }
        public void OnSelectExit()
        {
            this.transform.parent.GetComponent<Animator>().Play("L2 Piano None");
        }
    }
}