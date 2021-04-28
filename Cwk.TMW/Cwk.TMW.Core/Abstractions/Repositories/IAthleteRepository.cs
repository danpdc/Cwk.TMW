using Cwk.TMW.Common.Types;
using Cwk.TMW.Core.Enums;
using Cwk.TMW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwk.TMW.Core.Abstractions.Repositories
{
    public interface IAthleteRepository
    {
        Task<Athlete> CreateAthleteAsync(Athlete athlete);
        Task<Athlete> UpdateProfileSettingsAsync(int athleteId, ProfileSettings settings);
        Task<Athlete> UpdateProfileLocationAsync(int athleteId, ProfileLocation location);
        Task<Athlete> UpdateBasicInfoAsync(int athelteId, Gender gender, Uri profilePhoto = null, DateTimeOffset dob = default(DateTimeOffset),
            Height height = null, Weight weigh = null);
        Task<Athlete> DeleteAthleteAsync(int ahtleteId);

    }
}
