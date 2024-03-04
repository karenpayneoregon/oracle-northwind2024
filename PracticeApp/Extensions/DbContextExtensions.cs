using Microsoft.EntityFrameworkCore;
using PracticeApp.Classes;
using Dapper;

namespace PracticeApp.Extensions;
public static class DbContextExtensions
{
    public static void AddNewRecordLogic(this DbContext context)
    {
        var addedEntries = context.ChangeTracker
            .Entries()
            .Where(e => e.State == EntityState.Added);

        foreach (var entry in addedEntries)
        {
            if (entry.Entity is IHasSequencer sequencerEntity)
            {
                
                sequencerEntity.Id = context.Database.GetDbConnection()
                    .QuerySingle<int>(sequencerEntity.GetSequenceStatement().ToString());
            }
        }
    }
}
