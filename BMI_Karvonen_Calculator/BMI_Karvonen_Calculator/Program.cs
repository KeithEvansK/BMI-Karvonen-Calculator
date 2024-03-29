/*
 * Keith Evans
 * Exercise 3 - BMI and Karvonen Calculator
 * 2/19/2024
 * CSCI-1630
 * Dr. I
 * WEB-82771
 * 
 * This application takes input from the user about their health and outputs BMI and heart rate info.
 * 
 */


// Introduction Title
Console.WriteLine("BMI and Karvonen Calculator");
Console.WriteLine("");
Console.WriteLine("Please enter the following values for the user . . . ");
Console.WriteLine("");

// Taking Input
Console.Write("Height in inches: ");
int height = int.Parse(Console.ReadLine());

Console.Write("Weight in pounds: ");
int weight = int.Parse(Console.ReadLine());

Console.Write("Age: ");
int age = int.Parse(Console.ReadLine());

Console.Write("Resting heart rate: ");
int restingHeartRate = int.Parse(Console.ReadLine());


// Results Title
Console.WriteLine(" ");
Console.WriteLine("Results . . . ");
Console.WriteLine(" ");




// BMI Results
// Calculate BMI Results
double bmi = Math.Round((weight * 0.45359237) / (Math.Pow(height * 0.0254, 2)), 2); // Convert weight lbs to kg. Convert height inch to meters. Calculate BMI. kg / m^2.

// Determine BMI Status
string bmiStatus = "";

if (bmi < 18.5) {
    bmiStatus = "Underweight";

}
else if( (bmi >= 18.5) && (bmi <= 24.9) ) {
    bmiStatus = "Normal weight";

}
else if ((bmi >= 25) && (bmi <= 29.9)) {
    bmiStatus = "Overweight";

}
else {
    bmiStatus = "Obesity";

}

// Display Results to user
Console.WriteLine("Your BMI is: " + bmi.ToString() + " -- " + bmiStatus);

Console.WriteLine(" ");

// Calculate Exercise Intensity Heart Rate
Console.WriteLine("Exercise Intensity Heart Rates: ");
Console.WriteLine("Intensity       Max Heart Rate");
Console.WriteLine(" ");

double exerciseIntensity = .50; // Beginning exercise intensity heart rate 50%


while (exerciseIntensity <= 1) { // While exercise intensity heart rate is less than 100%



    // tzz calculation
    double tzz = (((220 - age) - restingHeartRate) * exerciseIntensity) + restingHeartRate;


    // Output to the user.
    Console.WriteLine(Math.Round(exerciseIntensity * 100, 2).ToString() + "%" + "     --      " + Math.Round(tzz, 2).ToString());

    exerciseIntensity += .05; // Increase heart rate intensity by 5%
}

