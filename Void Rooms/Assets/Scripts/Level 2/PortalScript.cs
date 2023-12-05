using UnityEngine;
using UnityEngine.SceneManagement;

namespace Level_2
{
    public class PortalScript : MonoBehaviour
    {
        public GameObject portal;
        public AudioClip portalLoopBGM;
        public GameObject gameManager2;

        private bool portalOpened;
        private void Awake()
        {
            GameManager.instance.portalOpened.AddListener(OpenPortal);
        }


        private void OpenPortal()
        {
            portal.SetActive(true);
            portalOpened = true;
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(portalLoopBGM);
        }

        private void OnTriggerEnter(Collider col)
        {
            if (col.CompareTag("Player") && portalOpened)
            {
                Destroy(gameManager2);
                GameManager.instance.PlaySFX("portalEnter");
                SceneManager.LoadScene("Backrooms GameOver");
            }
            
        }
    }
}