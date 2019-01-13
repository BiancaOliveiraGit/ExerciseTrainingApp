using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingAppAspCore
{
    public static class RouteUri
    {
        public const string UriClients = "/api/client";
        public static string UriClientById(int id)
        {
            string uri = "/api/client/";
            if (id != 0)
            {
                uri += "/" + id.ToString();
            }
            return uri;
        }

        public const string UriVideos = "/api/video";
        public const string UriWorkoutPlans = "/api/workoutplan";
        public const string UriWorkoutExercises = "/api/workoutexercise";

        public const string UriClientWorkouts = "/api/clientworkout";
        public static string UriClientWorkoutsById(int id)
        {
            string uri = "/api/clientworkout/client";
            if (id != 0)
            {
                uri += "/" + id.ToString();
            }
            return uri;
        }
    }
}
