using DemoLesson1.Models;
using System;
using System.Linq;

namespace DemoLesson1 {
    class Program {
        static void Main(string[] args) {
            var fakeRepo = new FakeWorkoutRepository();

            var outside = fakeRepo
                .GetWorkouts()
                .Where(w => w.IsOutside ?? false);

            foreach (var workout in outside) {
                Console.WriteLine($"{workout.Title} starts at {workout.StartTime}");
            }
            
        }
    }
}
