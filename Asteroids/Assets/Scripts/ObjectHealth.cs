 using UnityEngine; 
 using System.Collections;
 
 public class ObjectHealth : MonoBehaviour { 

 private UpdateScore UpdateScore;
 public float maxHealth = 100f; 
 public float curHealth = 100f;
 public int scoreValue = 10;

 public bool spawnDebris= false;
 public GameObject destroyedversion;
 
 //initialization 

 void Awake(){
    UpdateScore = GameObject.FindObjectOfType<UpdateScore>();
}
 void Start () {  } 
 
 // Update 
 void Update () { 
     if (curHealth <1){ 
         if (spawnDebris == true){
            Instantiate(destroyedversion, transform.position, transform.rotation);
            Destroy(gameObject);
            UpdateScore.Score(scoreValue);

         }else{
            Destroy(gameObject); 
         }
     } 
 } 


 void OnCollisionEnter(Collision col) 
 { 
     if (col.gameObject.tag == "CrystalProjectile")
     { 
        curHealth -= ProjectileDamage.CrystalDamage;
     } 
}
}