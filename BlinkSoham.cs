const int buttonPin = 2; 
const int ledPin = 13;   


const char* morseCode[] = {"... ---","--- ...","....",".-","--"}; 

void setup() {
  pinMode(buttonPin, INPUT); 
  pinMode(ledPin, OUTPUT);   
}

void loop() {
  if (digitalRead(buttonPin) == HIGH) { 
    blinkName(); 
  }
}

void blinkName() {
  for (int i = 0; i < sizeof(morseCode) / sizeof(morseCode[0]); i++) {
    const char* letter = morseCode[i];
    for (int j = 0; letter[j] != '\0'; j++) {
      if (letter[j] == '.') {
        digitalWrite(ledPin, HIGH); 
        delay(250); 
        digitalWrite(ledPin, LOW); 
        delay(250); 
      } else if (letter[j] == '-') {
        digitalWrite(ledPin, HIGH); 
        delay(750); 
        digitalWrite(ledPin, LOW); 
        delay(250); 
      }
    }
    delay(500); 
  }
  delay(1000);
}