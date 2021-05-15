 
// The target we are following
var target : Transform;
// The distance in the x-z plane to the target
var distance = 10.0;
// the height we want the camera to be above the target
var height = 5.0;
// How much we want to dampen the height
var heightDamping = 2.0;
 
function LateUpdate () {
    // Early out if we don't have a target
    if (!target)
        return;
   
    wantedHeight = target.position.y + height;
    currentHeight = transform.position.y;
 
    // Damp the height
    currentHeight = Mathf.Lerp (currentHeight, wantedHeight, heightDamping * Time.deltaTime);
   
    // Set the position of the camera on the x-z plane to:
    // distance meters behind the target
    transform.position = target.position;
    transform.position -= Vector3.forward*distance;
 
    // Set the height of the camera
    transform.position.y = currentHeight;
   
    // Always look at the target
    transform.LookAt (target);
   
}
 
