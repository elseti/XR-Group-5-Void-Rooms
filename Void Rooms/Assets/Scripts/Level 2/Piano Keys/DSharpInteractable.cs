using UnityEngine;

namespace Level_2.Piano_Keys
{
    public class DSharpInteractable : IInteractable
    {
        private AudioSource audioSource;
        
        private void Start()
        {
            audioSource = this.gameObject.GetComponent<AudioSource>();
        }
        
        public void OnSelectEnter()
        {
            this.transform.parent.GetComponent<Animator>().Play("L2 Piano D#");
            audioSource.PlayOneShot(GameManager.instance.GetSFX("pianoD#"));
            PianoManager.instance.PressNote("d#");
        }
        public void OnSelectExit()
        {
            this.transform.parent.GetComponent<Animator>().Play("L2 Piano None");
        }
    }
}