using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class CallorSmoke : MonoBehaviour
{
    float rndCase;
    public GameObject radioSound;
    public GameObject explotion1;
    public GameObject smokeParticles;


    // Start is called before the first frame update
    void Start()
    {
        rndCase = Random.Range(0, 1);

        radioSound.SetActive(false);
        explotion1.SetActive(false);
        smokeParticles.SetActive(false);

        Debug.Log(rndCase.ToString());

        //Case 1, turn the radio
        if (rndCase == 0)
        {
            PhoneCase();
        }
        //case 2, turn smoke
        else
        {
            SmokeCase();
        }
    }

    async void PhoneCase()
    {
        Debug.Log("telefono activado");
        radioSound.SetActive(true);
        await Task.Delay(10000);
        Debug.Log("humo activado");
        smokeParticles.SetActive(true);
        await Task.Delay(5000);
        explotion1.SetActive(true);
     
    }

    async void SmokeCase() 
    {
        Debug.Log("humo");
        await Task.Delay(10000);
        smokeParticles.SetActive(true);
        await Task.Delay(5000);
        explotion1.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
