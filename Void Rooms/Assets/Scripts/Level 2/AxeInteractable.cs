using UnityEngine;

namespace Level_2
{
    public class AxeInteractable : IInteractable
    {
        private bool isSelected;

        public void OnSelectEnter()
        {
            isSelected = true;
        }
        private void OnCollisionEnter(Collision col)
        {
            if (isSelected)
            {
                if (col.gameObject.CompareTag("Ground"))
                {
                    GameManager.instance.PlaySFX("weaponFall");
                    isSelected = false;
                }
                else if (col.gameObject.CompareTag("WaterGround"))
                {
                    GameManager.instance.PlaySFX("weaponWaterFall");
                    isSelected = false;
                }
            }
        }
    }
}