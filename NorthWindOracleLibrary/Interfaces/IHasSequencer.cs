namespace NorthWindOracleLibrary.Interfaces;

    public interface IHasSequencer
    {
        int Id { get; set; }
        FormattableString GetSequenceStatement();
    }