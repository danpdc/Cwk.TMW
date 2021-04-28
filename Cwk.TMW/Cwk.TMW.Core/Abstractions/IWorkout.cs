using Cwk.TMW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwk.TMW.Core.Abstractions
{
    public interface IWorkout
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        DateTimeOffset DateCreated { get; set; }
        DateTimeOffset DateUpdated { get; set; }
        int Duration { get; set; }
        int AthleteId { get; set; }
        Athlete Athlete { get; set; }
    }
}
