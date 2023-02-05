using UnityEngine;

public class MuzzleHeat : MonoBehaviour
{
    // public variable to store the muzzle material 
    public Material muzzleMaterial;
    // public variable to store the fire key code
    public KeyCode fire;
    // private variable to store semi-automatic state
    private bool semiState;
    // public variable to enable/disable semi-automatic firing mode
    public bool semiAuto;
    // private variable to check if muzzle heat is in use
    private bool usesMuzzleHeat = true;
    // private variable to check if the muzzle is cooling down
    private bool coolingDown;
     
    // Reset when weapon is selected
    private void OnEnable()
	{
		if (usesMuzzleHeat)
		{
			muzzleMaterial.SetColor("_EmissionColor", muzzleMaterial.GetColor("_EmissionColor") - new Color(0, 0, 0));
		}
	} 
     
    private void Update()
    {
        // Check if fire key is pressed
        if (Input.GetKey(fire))
        {
            // Check if semi-automatic firing mode is enabled
            if (semiAuto)
            {
                // Check if the semi-automatic state is not set
                if (!semiState)
                {
                    Fire();
                    semiState = true;
                }
            }
            else
            {
                Fire();
            }
        }
        else
        {
            // Check if muzzle heat is in use
            if (usesMuzzleHeat)
            {
                // Check if muzzle is not cooling down
                if (!coolingDown)
                {
                    StartCoroutine(CoolMuzzle());
                    coolingDown = true;
                }
            }
        }
    }

    // Function to fire
    private void Fire()
    {
        // code to fire goes here
    }

    // Coroutine to cool down the muzzle
    IEnumerator CoolMuzzle()
    {
        // Decrement the emission color of the muzzle material until it reaches zero
        while (muzzleMaterial.GetColor("_EmissionColor").r > 0)
        {
            muzzleMaterial.SetColor("_EmissionColor", muzzleMaterial.GetColor("_EmissionColor") - new Color(0.01f, 0, 0));
            yield return new WaitForSeconds(0.1f);
        }
    }
}
