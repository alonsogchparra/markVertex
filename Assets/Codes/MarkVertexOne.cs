using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkVertexOne : MonoBehaviour {

	public GameObject myBox;
	public MeshFilter myMesh;
	public List<Transform> boxes;

	// Use this for initialization
	void Start () {

		Vector3 [] vertices = GetComponent<MeshFilter>().mesh.vertices;

		foreach(Vector3 vertice in vertices) {

			GameObject box = Instantiate(myBox,vertice, Quaternion.identity);
			box.transform.SetParent(this.transform);
			box.transform.localPosition = vertice;

		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
