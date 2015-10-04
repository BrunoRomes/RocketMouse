using UnityEngine;
using System.Collections;

public class CreatingParticleSortingLayerFix : MonoBehaviour {

	void Start () {
		GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = "Player";
		GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingOrder = -1;
	}
}
