using UnityEngine;

namespace Level_2.Piano_Keys
{
    public class BInteractable : IInteractable
    {
        private AudioSource audioSource;
        
        private void Start()
        {
            audioSource = this.gameObject.GetComponent<AudioSource>();
        }
        
        public void OnSelectEnter()
        {
            this.transform.parent.GetComponent<Animator>().Play("L2 Piano B");
            audioSource.PlayOneShot(GameManager.instance.GetSFX("pianoB"));
            PianoManager.instance.PressNote("b");
        }
    }
}