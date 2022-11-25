using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateDecoys : MonoBehaviour
{
    public GameObject Decoy;
    public GameObject[] Decoys;

    // variable for spawn amount of method
    public int spawnAmount = 5;

    // variables for randomizsing the spawn position
    public float spawnPositionX = 15f;
    public float spawnPositionZ = 15f;

    // variables for Invoke Repeating   
    public float startDelay = 2f;
    public float spawnInterval = 3f;


    // Start is called before the first frame update
    void Start()
    {
        // Use InvokeRepeating if you want to spawn a method with a start delay and repeating time interval
            // InvokeRepeating("SpawningDecoys", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Input.GetKeyDown("space"))
        {

            // Instantiate one decoy prefab at the transform position and rotation of the object, this script is attached to
                // Instantiate(Decoy, transform.position, transform.rotation);

            // use a for loop to instantiate a clone of the game object at the spawnAmount defined prefabs at a randomized position 
                // for (int i = 0; i < spawnAmount; i++)
                // {
                //     // generate random spawn position between the defined values
                //     Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX,spawnPositionX),0,Random.Range(-spawnPositionZ,spawnPositionZ));

                //     // instantiate decoy
                //     Instantiate(Decoy, spawnPosition, transform.rotation);
                // }

            // call the method to spawn x amount (in this case 5) decoys. for each decoy one prefab from the decoys array is selected
                // SpawningDecoys();
        
            // call the method with the argument spawnAmount to spawn X decoys with space
                SpawningDecoyParam(spawnAmount);
        }

    }


    // your custom method to spawn one randomly selected decoy from the decoys arry, once the method is called
    void SpawningDecoys()
    {
            for (int i = 0; i < 5; i++)
            {
                // here we use the array of decoys and randomly generate the index number of the array, to pick various decoys for each spawn
                int decoysIndex = Random.Range(0,Decoys.Length);

                // generate random spawn position between the defined values
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX,spawnPositionX),0,Random.Range(-spawnPositionZ,spawnPositionZ));

                // instantiate decoy (as we use the decoys array here, the decoys array index randomly generated above is used)
                Instantiate(Decoys[decoysIndex], spawnPosition, Decoys[decoysIndex].transform.rotation);
            }
    }



    // your custom method to spawn the decoy with the given amount paramenter, defined when the method is called inside its braces (see above)
    void SpawningDecoyParam(int amount)
    {
            for (int i = 0; i < amount; i++)
            {
                // generate random spawn position between the defined values
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX,spawnPositionX),0,Random.Range(-spawnPositionZ,spawnPositionZ));

                // instantiate decoy
                Instantiate(Decoy, spawnPosition, Decoy.transform.rotation);
            }
    }

}
