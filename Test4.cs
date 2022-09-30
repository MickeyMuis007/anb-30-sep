namespace Test
{
    using System;

    public class Test4
    {
        const double RADIUS_OF_EARTH_IN_METERS = 6371000;
        public int GetTotalMetersBetweenTwoPoints(Point point1, Point point2)
        {
            double diffLatitude = point2.Latitude - point1.Latitude;
            double diffLongitude = point2.Longitude - point1.Longitude;

            // Referenced https://www.geeksforgeeks.org/program-distance-two-points-earth/#:~:text=For%20this%20divide%20the%20values,is%20the%20radius%20of%20Earth.
            // to calculate below.
            double a = Math.Pow(Math.Sin(diffLatitude/2), 2) + 
                Math.Cos(point1.Latitude) * Math.Cos(point2.Latitude) * Math.Pow(Math.Sin(diffLongitude/2), 2);
            double c = 2 * Math.Asin(Math.Sqrt(a));
            
            double distance = c * RADIUS_OF_EARTH_IN_METERS;

            return (int)Math.Round(distance, 0); // return the distance in meters between the points
        }

        private double _degree2Radius(double deg) {
            return deg * (Math.PI/180);
        }
    }

    public class Point 
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}