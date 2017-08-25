var carcam : GameObject ;
var player :  GameObject ;
var Exittrigger : GameObject ;
var car :  GameObject ;
var Exitplace :  GameObject ;

function update(){
    if (Input.GetButtonDown("Submit")){
        player.SetActive(true);
        player.transform.position = Exitplace.transform.position ;
        carcam.SetActive(false);
        car.GetComponent("CarController").enabled = false;
        car.GetComponent("CarUserControl").enabled = false ;
        Exittrigger.SetActive(false);
    }
}        