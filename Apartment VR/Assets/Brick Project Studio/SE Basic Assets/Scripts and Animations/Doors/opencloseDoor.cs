using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
	public class opencloseDoor : MonoBehaviour
	{

		public Animator openandclose;
		public bool open;
		public Transform Player;
		public Collider d_Collider;

		void Start()
		{
			open = false;
		}

		void Update()
        {
			{
				if (Player)
				{
					//Debug.Log("Player");

					/*if (Player.transform.hasChanged)
                    {
						Debug.Log("Player has moved");
						Player.transform.hasChanged = false;
					}*/


					float dist = Vector3.Distance(Player.position, transform.position);
					if (dist < 2)
					{
						if (open == false)
                        {
							d_Collider.enabled = false;
							Debug.Log("Collider Disabled!");
							StartCoroutine(opening());
						}
						
					}

					else
					{
						if (open == true)
                        {
							d_Collider.enabled = false;
							StartCoroutine(closing());
							d_Collider.enabled = true;
						}
						
					}
				}

			}
		}

		IEnumerator opening()
		{
			//print("you are opening the door");
			openandclose.Play("Opening");
			open = true;
			yield return new WaitForSeconds(1.5f);
			d_Collider.enabled = !d_Collider.enabled;
		}

		IEnumerator closing()
		{
			//print("you are closing the door");
			openandclose.Play("Closing");
			open = false;
			yield return new WaitForSeconds(1.5f);
		}


	}
}