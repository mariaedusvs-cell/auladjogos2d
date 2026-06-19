using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player"))
        {
            Pontuaçao pontuacao = other.GetComponent<Pontuaçao>();
            pontuacao.AddPoints();
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
}
