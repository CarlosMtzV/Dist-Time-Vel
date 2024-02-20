using Dist_vel_Time;

Console.Write("Enter the distance traveled (in meters): ");
double distance = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the elapsed time (in seconds): ");
double time = Convert.ToDouble(Console.ReadLine());

CalVel miVelocidad = new CalVel(distance, time);

double velocidad = miVelocidad.CalcularVelocidad();

Console.WriteLine("The speed is: " + velocidad + " meters / second ");
