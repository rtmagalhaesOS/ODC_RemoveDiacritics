using OutSystems.ExternalLibraries.SDK;

namespace OutSystems.RemoveDiacritics {

    /// <summary>
    /// Provides functionality to remove diacritical marks from strings.
    /// </summary>
    [OSInterface(Description = "Provides functionality to remove diacritical marks from strings.", IconResourceName = "OutSystems.RemoveDiacritics.resources.circumflex-accent.png")]
    public interface IRemoveDiacritics {

        [OSAction(Description = "Removes diacritical marks (accents) from the input text and returns the cleaned string.")]
        void RemoveStringDiacritics(string? text, out string cleanText);
    }
}
