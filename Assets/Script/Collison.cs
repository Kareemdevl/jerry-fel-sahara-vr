using UnityEngine;

public class Collison : MonoBehaviour
{
    [SerializeField] Transform carObject;

    Vector3 initialPosition = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = carObject.position;
        // Debug.Log(initialPosition);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.name);
        if (other.gameObject.CompareTag("obstcale"))
        {
            Debug.Log("YOU LOST");
            carObject.position = initialPosition;
        }


        if (other.gameObject.CompareTag("Win line"))
        {
            Debug.Log("YOU WON");
            Time.timeScale = 0;
        }
    }
}