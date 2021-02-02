using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLesson1.Models {
    class FakeWorkoutRepository : IWorkoutRepository {
      

        private List<Workout> fakeWorkouts =  new List<Workout> {
            new Workout (
                "HIT",
                new DateTime(2021,2,2,20,0,0),
                new TimeSpan(0,30,0)
                ),
            new Workout (
                "mountain bike",
                new DateTime(2021,2,3,10,0,0),
                new TimeSpan(1,30,0)
                ) { Price = 7.5M, IsOutside = true} // use of object initializer
        };

        public IEnumerable<Workout> GetWorkouts() =>
            fakeWorkouts;

        public void AddWorkout(Workout workout) =>
            fakeWorkouts.Add(workout);
    }
}
