using UnityEngine;

public class sv_gravity : MonoBehaviour
{
    

    void Update()
    {
        
                
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
            Physics2D.gravity = new Vector2(-9.8f, 0);
        }
                

       

               

                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
            Physics2D.gravity = new Vector2(0, 9.8f);
        }
                

          

                

                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
            Physics2D.gravity = new Vector2(9.8f, 0);
        }
                

            

                
                
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
            Physics2D.gravity = new Vector2(0, -9.8f);
        }

                
        
    }
}