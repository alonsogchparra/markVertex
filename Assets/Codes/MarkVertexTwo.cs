using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkVertexTwo : MonoBehaviour {

	public GameObject prefab;
	Vector3 [] verts;

	// Use this for initialization
	void Start () {

		verts = GetComponent<MeshFilter>().sharedMesh.vertices;

		for(int i = 0; i < verts.Length; i++) {
			
			Transform marker = Instantiate(prefab).transform;
			marker.SetParent(this.transform);
			marker.localPosition = verts[i];
			marker.LookAt(transform.position);

		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
