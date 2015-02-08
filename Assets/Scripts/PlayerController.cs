using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	float touchX, touchY;
	//public GUIText debugText;

	void FixedUpdate()	{
		const float speedModul = 0.1f;
		// Loop through the touches looking for a finger on the right button.
		//for (int t = 0; t < Input.touchCount; t++) 
		if(Input.touchCount==1)
		{
			int t = 0;
			if (Input.touches [t].phase == TouchPhase.Began)
			{
				touchX = Input.touches[t].position.x;
				touchY = Input.touches[t].position.y;
			}
			if( Input.touches [t].phase == TouchPhase.Moved || 
					Input.touches [t].phase == TouchPhase.Stationary) 
			{
				float  nowTouchX, nowTouchY, touchLenX, touchLenY;
				nowTouchX = Input.touches[t].position.x;
				nowTouchY = Input.touches[t].position.y;
				touchLenX = nowTouchX - touchX ;
				touchLenY = nowTouchY - touchY ;
				float touchLen = Mathf.Sqrt(Mathf.Pow (touchLenX , 2) + Mathf.Pow (touchLenY, 2) );

				rigidbody.velocity += new Vector3( touchLenX * speedModul / touchLen, touchLenY * speedModul / touchLen, 0);
				//Vector2 inputPosition = new Vector2 ((Input.touches[t].position.x - rigidbody.position.x)/100, (Input.touches[t].position.y - rigidbody.position.y)/100);
				//rigidbody.velocity = inputPosition;

				//angle = angle*Mathf.PI/180;
				//rigidbody.position = new Vector2 (Input.touches[t].position.x, Input.touches[t].position.y);

				/*
				float angle = 2*Mathf.PI + Mathf .Atan2(Input.touches[t].position.x - rigidbody.position.x, Input.touches[t].position.y - rigidbody.position.y);
				rigidbody.velocity  = new Vector3 (Mathf.Cos (angle) * speedModul , Mathf.Sin (angle) * speedModul, 0);
				*/

				//StackTraceUtility stu = new StackTraceUtility 
				//if (rigidbody.position.x > camera.po
				//debugText.text = string.Format("{0} - {1} - {2}", rigidbody.velocity.x, rigidbody.velocity.y, rigidbody.velocity.z);
				GameController.Trace(string.Format("{0} - {1} - {2}", rigidbody.velocity.x, rigidbody.velocity.y, rigidbody.velocity.z));
			}
		}

		//rigidbody.velocity = new Vector3 (1, 1,0);

/*		if (Input.mousePresent) {
			Vector2 inputPosition = new Vector2 (Input.mousePosition.x - rigidbody.position.x, Input.mousePosition.y - rigidbody.position.y);
			//Vector2 rocketPosition = 
			
			rigidbody.velocity = inputPosition;
		}
		*/

		rigidbody.rotation.SetLookRotation (rigidbody.velocity);		
	}
}
