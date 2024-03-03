namespace PracticeApp.Classes;

    public interface IHasSequencer
    {
        int Id { get; set; }
        FormattableString GetSequenceStatement();
    }