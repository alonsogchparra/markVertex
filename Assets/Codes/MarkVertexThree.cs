using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkVertexThree : MonoBehaviour {

	public GameObject prefab;
	Vector3[] verts;

	// Use this for initialization
	void Start () {
		verts = GetComponent<MeshFilter>().sharedMesh.vertices;

		foreach(Vector3 vert in verts) {
			
			Transform mark = Instantiate(prefab).transform;
			mark.SetParent(this.transform);
			mark.localPosition = vert;
			mark.LookAt(transform.position);

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
