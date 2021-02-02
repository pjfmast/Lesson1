using System;
using Xunit;
using DemoLesson1.Models;


namespace Tests {
    public class UnitTests {
        [Fact]
        public void Workout_EndTime_Should_Return_11h45m() {
            // Arrange
            Workout workout = new Workout(
                "trail run", 
                new DateTime(2021, 2, 5, 10, 0, 0), 
                new TimeSpan(1,45,0)
                );

            // Act
            DateTime expected = new DateTime(2021, 2, 5, 11, 45, 0);
            DateTime actual = workout.EndTime;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
