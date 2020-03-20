using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColorizeCountries : MonoBehaviour
{



    public List<GameObject> countriesList;
    public List<GameObject> copyOfCountries;

    private int counter;
    private int player;


    // Start is called before the first frame update
    void Start()
    {

        copyOfCountries = countriesList;
        counter = copyOfCountries.Count;
        player = 0;
        StartCoroutine(Up());
    }

    IEnumerator Up()
    {
        {
           while(counter !=0)
            
           
            {
                int randomIndex = (int)Random.Range(0, copyOfCountries.Count - 1);
                setColorOfCountrie(getColor(), getCountrieAtIndexFromCopy(randomIndex));


                counter--;
                yield return new WaitForSeconds(0.2f);

            }


            yield return null;


        }


        GameObject getCountrieAtIndexFromCopy(int index)
        {
            GameObject toReturn = copyOfCountries[index];
            copyOfCountries.RemoveAt(index);
            return toReturn;
        }


        void setColorOfCountrie(Color colorToSet, GameObject countrie)
        {
            countrie.GetComponent<Renderer>().material.color = colorToSet;

        }


        Color getColor()
        {
            if (player == 0)
            {
                player = 1;
                return Color.blue;

            }
            else
            {
                player = 0;
                return Color.red;
            }
        }


    }
}



