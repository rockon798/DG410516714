using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shot : MonoBehaviour {

    public Text countText;
    public Text winText;
    private int count;
	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
	}
        public float speed;

        Rigidbody rigidbody; 
	// Update is called once per frame
	void Update () {
        rigidbody.velocity = transform.forward * speed;
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 3)
        {
            winText.text = "勝利";
        }
    }
}
