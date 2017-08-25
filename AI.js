var Distance;
var Target : Transform;
var lookAtDistance = 25.0;
var attackRange = 15.0;
var moveSpeed = 5.0;
var Damping = 6.0;

function Update ()
{
	Distance = Vector3.Distance(Target.position, transform.position);

	
	if (Distance < lookAtDistance)
	{
		
		lookAt();
	}
	

	
	if (Distance < attackRange)
	{
		
		attack ();
	}
}

function lookAt ()
{
	var rotation = Quaternion.LookRotation(Target.position - transform.position);
	transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * Damping);
}

function attack ()
{
	
}