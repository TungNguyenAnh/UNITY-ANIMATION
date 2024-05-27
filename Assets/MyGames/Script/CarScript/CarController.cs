
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float maxHealth = 100;
    // public float moveSpeed = 15;
    public float diamondValue = 20;
    // public float rotateSpeed = 100;
    public float damageValue = 105;
    public GameObject explotionPrefab;
    public int roundValue = 1;
    public int coinValue = 2;


    private float currentHealth = 0;
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        // float horizontal = Input.GetAxis("Horizontal");
        // float vertical = Input.GetAxis("Vertical");

        // transform.Translate(new Vector3(0, 0, vertical * moveSpeed * Time.deltaTime));
        // transform.Rotate(new Vector3(0, horizontal * rotateSpeed * Time.deltaTime, 0));
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Diamond")
        {
            Destroy(other.gameObject);
            GameManager.Instance.SetDiamond(diamondValue);

        }
        else if (other.tag == "Damage")
        {
            Destroy(other.gameObject);
            Instantiate(other.gameObject);
            Debug.Log("Va cham dia hinh" + currentHealth);
        }
        else if (other.tag == "Goal")
        {
            GameManager.Instance.SetRoundNumber(roundValue);
        }
        else if (other.tag == "Coin")
        {
            Destroy(other.gameObject);
            GameManager.Instance.SetCoin(coinValue);
            Debug.Log("+1 Coin");
        }
    }

    private void damageHealth(float health)
    {
        if (currentHealth > 0)
        {
            currentHealth -= health;
        }
        else
        {
            currentHealth = 0;
            Destroy(gameObject);
        }

    }
}
