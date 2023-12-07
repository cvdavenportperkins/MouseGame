using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class SpriteChange : MonoBehaviour
{

    public SpriteRenderer sp;
    public Sprite newSprite;
    public Sprite oldSprite;
    bool changed = false;

    // Start is called before the first frame update
    void Start()
    {
        sp = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeSprite();
            changed = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            ChangeSprite();
            changed = false;
        }

    }
    void ChangeSprite()
    {
        if (changed)
        {
            sp.sprite = newSprite;
        }
        else
        {
            sp.sprite = oldSprite;
        }
    }
}

