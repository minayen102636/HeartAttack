using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;  

public class player_control : MonoBehaviour {     
	public gameManager game_con ;
	public Animator anim ;
	public float speed = 5;     
	public int jumpCoolDown = 10;      
	private Rigidbody2D rbody2D;     
	private int jumpCount;     
	private bool isJump;     

	// Use this for initialization     
	void Start () {         

		rbody2D = gameObject.GetComponent<Rigidbody2D> ();         
		jumpCount = 0;         
		isJump = false;     
	}      

	// Update is called once per frame     
	void Update () {         
		float dirx = Input.GetAxisRaw ("Horizontal");         
		rbody2D.velocity = new Vector2 (dirx * speed, rbody2D.velocity.y);          
		if (Input.GetKey (KeyCode.Space) && !isJump) {             
			isJump = true;             
			jumpCount = jumpCoolDown;             
			rbody2D.velocity += new Vector2 (0, speed);         
		}          

		if (jumpCount > 0) {             
			jumpCount -= 1;             
			if (jumpCount == 0) {                 
				isJump = false;             
			}         
		}  

		if (Mathf.Abs(rbody2D.velocity.y) > 0.01f) {             
			anim.SetInteger ("state", 2);         
		}         

		else if (dirx != 0) {             
			anim.SetInteger ("state", 1);         
		}         

		else {             
			anim.SetInteger("state", 0);      
			//bool int float"名稱" 
		}   

		if (dirx * this.transform.localScale.x < 0) {             
			this.transform.localScale = new Vector3(this.transform.localScale.x * -1, this.transform.localScale.y, 0);         
		}
	}

	void OnTriggerEnter2D(Collider2D col)
    {
    	if(col.gameObject.tag == "Heart")
    	{
       		Destroy(col.gameObject);
        	game_con.addScore(1);
        }

        else if(col.gameObject.tag == "Heart_2")
    	{
       		Destroy(col.gameObject);
        	game_con.addScore(5);
        }

        else
        {
        	Destroy(col.gameObject);
        	game_con.addScore(-10); 
        }
    }

 } 
