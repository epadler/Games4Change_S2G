using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crop : MonoBehaviour
{
    public int actionPoint;
    public Sprite[] sprites;
    public Maturity maturity;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponenet<SpriteRenderer>().sprite = sprites[0];
        maturity = Maturity.sapling;
        actionPoint = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Mature()
    {
        switch (maturity)
        {
            case Maturity.sapling:
                maturity = Maturity.young;
                break;
            case Maturity.young:
                maturity = Maturity.mature;
                break;
        }
        actionPoint++;
    }

    public void CutDown()
    {
        Debug.Log("hi");
        GameObject.Destroy(gameObject);

    }
    void OnMouseDown()
    {
        if (maturity == Maturity.mature)
        {
            CutDown();
        }
    }
}