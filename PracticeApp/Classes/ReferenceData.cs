using PracticeApp.Models;

namespace PracticeApp.Classes
{
    /// <summary>
    /// Since the database is not fully normalized the following reads
    /// static data which would in a normalized version of this database
    /// would be tables.
    /// </summary>
    public sealed class ReferenceData
    {
        private static readonly Lazy<ReferenceData> Lazy = new(() => new ReferenceData());
        public static ReferenceData Instance => Lazy.Value;
        public List<Countries> CountriesList { get; private set; }
        public List<ContactType> ContactTypesList { get; private set; }

        private ReferenceData()
        {
            CountriesList = ReferenceLists.CountriesList();
            ContactTypesList = ReferenceLists.ContactTypes;
        }
    }
}
