using UnityEngine;

namespace DefaultNamespace.Level_2
{
    public class MusicPaperInteractable : IInteractable
    {
        private bool isSelected;
        
        public void OnSelectEnter()
        {
            GameManager.instance.PlaySFX("paperGrab");
            isSelected = true;
        }
        
        private void OnCollisionEnter(Collision col)
        {
            if (isSelected)
            {
                if (col.gameObject.CompareTag("Ground"))
                {
                    GameManager.instance.PlaySFX("paperFall");
                    isSelected = false;
                }
                else if (col.gameObject.CompareTag("WaterGround"))
                {
                    GameManager.instance.PlaySFX("paperWaterFall");
                    isSelected = false;
                }
            }
            
        }
    }
}