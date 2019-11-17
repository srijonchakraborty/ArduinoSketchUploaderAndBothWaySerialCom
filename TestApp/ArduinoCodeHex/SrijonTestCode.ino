String cmdString;
void setup() {
  
  Serial.begin(9600);
  pinMode(13, OUTPUT);
}

// the loop function runs over and over again forever
void loop() {
  digitalWrite(13, HIGH);   
  delay(50);  //Change Delay to vary the Speed                  
  digitalWrite(13, LOW);   
  delay(50);  //Change Delay to vary the Speed             
  //Serial.println("High From Arduino");
  String s1 = Serial.readString();
  if(s1!="")
  {
    delay(2000);
    Serial.print("Response From Arduino => ");
    Serial.println(s1);//display same received Data back in serial monitor.
  }
}

