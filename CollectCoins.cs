using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    public int coins;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1; 
    }
    public void OnTriggerEnter(Collider Col) {
        if(Col.gameObject.tag == "Coin") {
            Debug.Log("Collected");
            coins = coins + 1;
            //Col.gameObject.SetActive(false);
            Destroy(Col.gameObject);
            Score.scoreValue = coins;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
