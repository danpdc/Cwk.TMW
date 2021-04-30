using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwk.TMW.Core.Abstractions.Repositories
{
    public interface IWorkoutRepository<T> : ITmwRepository where T : IWorkout
    {
        Task<T> CreateWorkoutAsync(T workout);
        Task<T> UpdateWorkoutAsync(T updatedWorkout);
        Task<T> DeleteWorkoutAsync(int workoutId);
        Task<ICollection<T>> GetWorkoutsForTimeIntervalAsync(DateTimeOffset startTime,
            DateTimeOffset endTime);
        Task<ICollection<T>> GetAthleterWorkoutsAsync(int athleteId);
        Task<ICollection<T>> GetAthleteWorkoutsForTimeIntervalAsync(int athleteId,
            DateTimeOffset startTime, DateTimeOffset endTime);
    }
}
