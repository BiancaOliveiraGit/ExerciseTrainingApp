using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingAppAspCore
{
    public static class RouteUri
    {
        public const string UriClients = "/api/client";
        private const string _uriClient = "/api/client";
        public static string UriClientById(int id)
        {
            string uri = _uriClient;
            if (id != 0)
            {
                uri += "/" + id.ToString();
            }
            return uri;
        }
        public static string UriClientByEmail(string email)
        {
            string uri = _uriClient;
            if (!string.IsNullOrEmpty(email))
            {
                uri += "/0?" + email;
            }
            return uri;
        }

        public const string UriVideos = "/api/video";
        public const string UriWorkoutPlans = "/api/workoutplan";
        public const string UriWorkoutExercises = "/api/workoutexercise";

        public const string UriClientWorkouts = "/api/clientworkout";
        private const string _uriClientWorkouts = "/api/clientworkout";
        public static string UriClientWorkoutsById(int id)
        {
            string uri = _uriClientWorkouts + "/client";
            if (id != 0)
            {
                uri += "/" + id.ToString();
            }
            return uri;
        }
    }
}
