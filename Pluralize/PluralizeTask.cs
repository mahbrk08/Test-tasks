namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
			// Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
            string word = "рублей";
            if (count % 10 == 1) 
            {
                word = "рубль";
            }
            else if (count % 10 >= 2 && count % 10 <= 4)
            {
                word = "рубля";
            } 
            
            return word;
            
		}
	}
}