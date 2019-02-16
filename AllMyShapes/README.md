### Shape Area and Perimeter Classes
Create an abstract class called Shape and then inherit from it other shapes like diamond, rectangle, circle, triangle etc. Then have each class override the area and perimeter functionality to handle each shape type.

#### What I learned
- Inheritance. Using abstract classes and overriding methods.
- Properties. Becoming familiar with implementing _get_ and _set._
- Encapsulation. Making sure that each method has a specific purpose.

#### Challeneges
- User input. FormatException.
I tried a few different ways to handle exceptions here, but for learning purposes I decided on TryParse() for all input. I can do that because this program only works with one data type: double. Because of this, I was able to make one method, getNumbersFromString(), and reuse it anywhere there is a Console.ReadLine(). I am happy with the way this particular method turned out and plan to utilize this code in future projects. 

#### Output
[picture]http://puu.sh/CMUut/5642593f26.png
