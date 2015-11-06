/*private var startTime: float;
private var restSeconds : int;
private var roundedRestSeconds : int;
static var displaySeconds : int;
private var displayMinutes : int;
var text :Text;
var countDownSeconds : int; // en esta variable se indica cuando segundos durará el nivel

function Awake() {
    startTime = Time.time;
}

function OnGUI () {
    var guiTime : float = (Time.time) - (startTime);
    restSeconds = countDownSeconds + (guiTime);


    //Muestro el cronómetro
    roundedRestSeconds = Mathf.CeilToInt(restSeconds);
    displaySeconds = roundedRestSeconds % 60;
    displayMinutes = roundedRestSeconds / 60;

    text = String.Format ("{0:00}:{1:00}", displayMinutes, displaySeconds);
    
}*/