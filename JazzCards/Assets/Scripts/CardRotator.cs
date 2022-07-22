using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardRotator : MonoBehaviour
{
    // Canvas and buttons to control rotation
    public Canvas button_canvas;

    // Cards
    public GameObject start_card;
    public GameObject left_card;
    public GameObject right_card;
    public GameObject stack_card;

    // List of positions of cards
    public List<Vector3> card_positions_list;
    public List<Vector3> card_rotations_list;



    // Start is called before the first frame update
    void Start()
    {
        start_card = GameObject.Find("StartCard"); if (start_card == null) Debug.Log("Didn't find start_card");
        left_card = GameObject.Find("LeftCard"); if (left_card == null) Debug.Log("Didn't find left_card");
        right_card = GameObject.Find("RightCard"); if (right_card == null) Debug.Log("Didn't find right_card");
        stack_card = GameObject.Find("stack_card"); if (start_card == null) Debug.Log("Didn't find stack_card");

        Vector3 shown_card_pos = new Vector3(0.0f, 1.0f, -2.0f);
        Vector3 left_card_pos = new Vector3(-7.5f, 0.0f, 4.0f);
        Vector3 right_card_pos = new Vector3(7.5f, 1.0f, 4.0f);
        Vector3 stack_card_pos = new Vector3(0.0f, -4.5f, 8.0f);

        StartCoroutine(RotateCards());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator RotateCards()
    {


        yield break;
    }
}
