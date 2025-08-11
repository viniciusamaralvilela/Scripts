using UnityEngine;

public class coletavel1 : MonoBehaviour
{
    Player player;
    private contador cont;

    void Awake()
    {
        cont = FindObjectOfType<contador>();
    }

    void Start()
    {
        player = FindObjectOfType<Player>();

        if (player == null)
        {
            Debug.LogError("Player não encontrado na cena!");
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            cont.textUpdate(player.AddTeste(1));
            Destroy(gameObject, 0.05f); // permite a Unity terminar o processamento antes de remover
        }
    }
}
