using UnityEngine;
using System.Collections;

public class MovePlataform : MonoBehaviour {

    public GameObject plataform;
    public float speed;

    [Header("Path")]
    [Tooltip("Initial position of the plataform")]
    public Transform A;

    [Tooltip("Final position of the plataform")]
    public Transform B;

    private Transform _destiny;
    private int _rote;

    // Use this for initialization
    void Start()
    {

        _rote = 0;
        plataform.transform.position = A.position;
        _destiny = B;

    }

    // Update is called once per frame
    void Update()
    {

        float step = speed * Time.deltaTime;
        plataform.transform.position = Vector3.MoveTowards(plataform.transform.position, _destiny.position, step);

        if (plataform.transform.position == _destiny.position)
        {

            //StartCoroutine(wait());

            switch (_rote)
            {

                case 0:
                    _destiny = A;
                    _rote = 1;
                    break;
                case 1:
                    _destiny = B;
                    _rote = 0;
                    break;
            }

        }

    }

    IEnumerator wait()
    {
        float aux = speed;
        speed = 0;
        yield return new WaitForSeconds(1);
        speed = aux;
    }
}
