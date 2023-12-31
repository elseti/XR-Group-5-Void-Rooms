using UnityEngine;

namespace Level_2.Piano_Keys
{
    public class GInteractable : IInteractable
    {
        private AudioSource audioSource;
        
        private void Start()
        {
            audioSource = this.gameObject.GetComponent<AudioSource>();
        }
        
        public void OnSelectEnter()
        {
            this.transform.parent.GetComponent<Animator>().Play("L2 Piano G");
            audioSource.PlayOneShot(GameManager.instance.GetSFX("pianoG"));
            PianoManager.instance.PressNote("g");
        }
        public void OnSelectExit()
        {
            this.transform.parent.GetComponent<Animator>().Play("L2 Piano None");
        }
    }
}