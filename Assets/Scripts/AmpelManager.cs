using UnityEngine;

public class AmpelManager : MonoBehaviour
{
    private float totalTime = 13f; //13 seconds

    [SerializeField] private bool isAmpelGreen; //ampel

    [SerializeField] private Material red; //red material
    [SerializeField] private Material green; //green material
    
    private void Update()
    {
        totalTime -= Time.deltaTime;
        UpdateLevelTimer(totalTime ); 
    }

    private void FixedUpdate()
    {
        if (isAmpelGreen)
        {
            red.color = Color.gray;
            green.color = Color.green;
        } else
        {
             red.color = Color.red;
             green.color = Color.gray;
        }
        
    }

    public void UpdateLevelTimer(float totalSeconds)
    {
        int seconds = Mathf.RoundToInt(totalSeconds % 60f);

        if (seconds == 0)
        {
            totalTime = 13f;
            if (isAmpelGreen) isAmpelGreen = false;
                else isAmpelGreen = true;
        }
    }
}
