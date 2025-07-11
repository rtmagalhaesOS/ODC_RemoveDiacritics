using System.Globalization;
using System.Text;

namespace OutSystems.RemoveDiacritics {

    public class RemoveDiacritics : IRemoveDiacritics {
        
        /// <summary>
		/// Removes accents from text
		/// </summary>
		/// <param name="ssText"></param>
		/// <param name="ssCleanText"></param>
		public void RemoveStringDiacritics(string text, out string cleanText)
        {
            cleanText = "";

            var cleanString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var s in cleanString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(s);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(s);
            }

            cleanText = stringBuilder.ToString().Normalize(NormalizationForm.FormC);

        } // RemoveStringDiacritics
    }
}