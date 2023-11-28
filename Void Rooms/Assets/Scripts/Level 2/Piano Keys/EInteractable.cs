using UnityEngine;

namespace Level_2.Piano_Keys
{
    public class EInteractable : IInteractable
    {
        private AudioSource audioSource;
        
        private void Start()
        {
            audioSource = this.gameObject.GetComponent<AudioSource>();
        }
        
        public void OnSelectEnter()
        {
            this.transform.parent.GetComponent<Animator>().Play("L2 Piano E");
            audioSource.PlayOneShot(GameManager.instance.GetSFX("pianoE"));
            PianoManager.instance.PressNote("e");
        }
    }
}