using UnityEngine;

namespace Level_2.Piano_Keys
{
    public class FInteractable : IInteractable
    {
        private AudioSource audioSource;
        
        private void Start()
        {
            audioSource = this.gameObject.GetComponent<AudioSource>();
        }
        
        public void OnSelectEnter()
        {
            this.transform.parent.GetComponent<Animator>().Play("L2 Piano F");
            audioSource.PlayOneShot(GameManager.instance.GetSFX("pianoF"));
            PianoManager.instance.PressNote("f");
        }
    }
}