
var carcam : GameObject ;
var player : GameObject ;
var Exittrigger : GameObject ;
var car : GameObject ;
var triggercheck : int ;

function ontriggerEnter(col : Collider) {
    triggercheck = 1 ;
}
function ontriggerExit(col : Collider) {
    triggercheck = 0 ;
}
function update(){
    if (triggercheck == 1 ){
        if (Input.GetButtonDown("Submit")){
            carcam.SetActive(true);
            player.SetActive(false);
            car.GetComponent("CarController").enabled = true ;
            car.GetComponent("CarUserControl").enabled = true ;
            Exittrigger.SetActive(true);
        }
    }
}                    