using UnityEngine;

namespace Level_2.Piano_Keys
{
    public class CSharpInteractable : IInteractable
    {
        private AudioSource audioSource;
        
        private void Start()
        {
            audioSource = this.gameObject.GetComponent<AudioSource>();
        }
        
        public void OnSelectEnter()
        {
            this.transform.parent.GetComponent<Animator>().Play("L2 Piano C#");
            audioSource.PlayOneShot(GameManager.instance.GetSFX("pianoC#"));
            PianoManager.instance.PressNote("c#");
        }
        public void OnSelectExit()
        {
            this.transform.parent.GetComponent<Animator>().Play("L2 Piano None");
        }
    }
}