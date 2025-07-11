using OutSystems.ExternalLibraries.SDK;

namespace OutSystems.RemoveDiacritics {

    /// <summary>
    /// Provides functionality to remove diacritical marks from strings.
    /// </summary>
    [OSInterface(Description = "Provides functionality to remove diacritical marks from strings.", IconResourceName = "OutSystems.RemoveDiacritics.resources.circumflex-accent.png")]
    public interface IRemoveDiacritics {
        void RemoveStringDiacritics(string text, out string cleanText);
    }
}