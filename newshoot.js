//#pragma strict
//var Distance;
//var bullet      : Transform;
//var bulletSpawn : Transform;
//var timeBetweenShots = 1.0;
//var MinDist = 70.0;
//var MaxDist = 50.0;
//var player : Transform;  
//var MoveSpeed =10.0;
//private var timestamp = 0.0;
//  
// function Update ()  {
//     transform.LookAt(Player);
//  
//     if(Vector3.Distance(transform.position,Player.position) >= MinDist) {
//         transform.position += transform.forward*MoveSpeed*Time.deltaTime;
//  }
//         if(Vector3.Distance(transform.position,Player.position) <= MaxDist && (Time.time > timestamp)) {
//             Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
//             timestamp = Time.time + timestamp;
//         } 
//     
// }
//
