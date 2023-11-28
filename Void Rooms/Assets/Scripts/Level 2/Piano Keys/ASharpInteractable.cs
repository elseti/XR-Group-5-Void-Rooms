using UnityEngine;

namespace Level_2.Piano_Keys
{
    public class ASharpInteractable : IInteractable
    {
        private AudioSource audioSource;
        
        private void Start()
        {
            audioSource = this.gameObject.GetComponent<AudioSource>();
        }
        
        public void OnSelectEnter()
        {
            this.transform.parent.GetComponent<Animator>().Play("L2 Piano A#");
            audioSource.PlayOneShot(GameManager.instance.GetSFX("pianoA#"));
            PianoManager.instance.PressNote("a#");
        }
    }
}