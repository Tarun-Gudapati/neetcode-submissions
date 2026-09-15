public class Solution
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        var cars = new List<(int position, double time)>();

        for (int i = 0; i < position.Length; i++)
        {
            double time =
                (double)(target - position[i]) / speed[i];

            cars.Add((position[i], time));
        }

        cars.Sort((a, b) => b.position.CompareTo(a.position));

        int fleets = 0;
        double currentFleetTime = 0;

        foreach (var car in cars)
        {
            if (car.time > currentFleetTime)
            {
                fleets++;
                currentFleetTime = car.time;
            }
        }

        return fleets;
    }
}