using UnityEngine;

public class coletavel1 : MonoBehaviour
{
    Player player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //mudei pq tava dando bug para encontrar player
        player = FindObjectOfType<Player>();

        if (player == null)
        {
            Debug.LogError("Player não encontrado na cena!");
        }
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnTriggerEnter2D(Collider2D col)

    {

        if (col.CompareTag("Player"))

        {

            player.AddTeste(1);

            Destroy(gameObject);

        }

    }
}
