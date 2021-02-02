using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLesson1.Models {
    interface IWorkoutRepository {
        IEnumerable<Workout> GetWorkouts();
        void AddWorkout(Workout workout);
    }
}
