using UnityEngine;
using System.Collections;
using Assets.Scripts.Auxiliar.MonoEnums;

public class CheckPoint : MonoBehaviour {
    [Tooltip("Number of this checkpoint")]
    public int index;

    [HideInInspector]
    public Vector3 position;

	// Use this for initialization
	void Start () {
        position = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == ETagName.Player.GetDescription())
        {
            Player monoPlayer = FindObjectOfType<Player>();
            if (monoPlayer != null)
                monoPlayer.SetCheckpoint(this);
        }
    }
}
