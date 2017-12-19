using UnityEngine;

[System.Serializable]

public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class readAlexa : MonoBehaviour {

    //public float speed;
    //public float tilt;
    //public Boundary boundary;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("nome do objeto: " + GetComponent<SkinnedMeshRenderer>().name.ToString());
    }

    void FixedUpdate()
    {

    }

}
