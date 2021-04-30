using Cwk.TMW.Common.Types;
using Cwk.TMW.Core.Abstractions.Repositories;
using Cwk.TMW.Core.Enums;
using Cwk.TMW.Core.Models;
using Cwk.TMW.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwk.TMW.Infrastructure.Repositories
{
    public class AthleteRepository : IAthleteRepository
    {
        private readonly TmwDbContext _ctx;
        public AthleteRepository(TmwDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<Athlete> CreateAthleteAsync(Athlete athlete)
        {
            try
            {
                if (athlete == null)
                    throw new ArgumentNullException("Athlete cannot be null");

                _ctx.Athletes.Add(athlete);
                await _ctx.SaveChangesAsync();
                return athlete;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public async Task<Athlete> DeleteAthleteAsync(int athleteId)
        {
            try
            {
                var athlete = await _ctx.Athletes.FirstOrDefaultAsync(at => at.Id == athleteId);
                if (athlete == null)
                    throw new ArgumentException($"No athlete with ID {athleteId} found in the database");

                _ctx.Athletes.Remove(athlete);
                await _ctx.SaveChangesAsync();
                return athlete;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Athlete> UpdateBasicInfoAsync(int athelteId, Gender gender, 
            Uri profilePhoto = null, DateTimeOffset dob = default, 
            Height height = null, Weight weight = null)
        {
            try
            {
                var athlete = await _ctx.Athletes.FirstOrDefaultAsync(a => a.Id == athelteId);
                if (athlete == null)
                    throw new ArgumentException($"No athlete with ID {athelteId} found in the database");

                athlete.Gender = gender;

                if (profilePhoto != null)
                    athlete.ProfilePhotoUrl = profilePhoto;

                if (dob != default(DateTimeOffset))
                    athlete.DateOfBirth = dob;

                if (height != null)
                    athlete.Height = height;

                if (weight != null)
                    athlete.Weight = weight;

                _ctx.Athletes.Update(athlete);
                await _ctx.SaveChangesAsync();
                return athlete;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<Athlete> UpdateProfileLocationAsync(int athleteId, ProfileLocation location)
        {
            throw new NotImplementedException();
        }

        public Task<Athlete> UpdateProfileSettingsAsync(int athleteId, ProfileSettings settings)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
