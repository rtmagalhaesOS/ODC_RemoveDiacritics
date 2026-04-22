using System.Globalization;
using System.Text;

namespace OutSystems.RemoveDiacritics {

    public class RemoveDiacritics : IRemoveDiacritics {

        /// <summary>
        /// Removes diacritical marks (accents) from the input text.
        /// </summary>
        /// <param name="text">The input string to process.</param>
        /// <param name="cleanText">The resulting string with diacritics removed.</param>
        public void RemoveStringDiacritics(string? text, out string cleanText)
        {
            if (string.IsNullOrEmpty(text))
            {
                cleanText = text ?? string.Empty;
                return;
            }

            var normalized = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder(normalized.Length);

            foreach (var c in normalized)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(c);
            }

            cleanText = stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
