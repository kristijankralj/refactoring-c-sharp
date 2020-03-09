namespace SimplifyingConditional
{
    public class Practice
    {
        public string GetFormattedSQL(string original, ISQLFormatter formatter)
        {
            if (!string.IsNullOrEmpty(original))
            {
                string selectKeyword = "select";
                string fromKeyword = "from";
                string insertKeyword = "insert";
                string intoKeyword = "into";
                string updateKeyword = "update";
                string setKeyword = "set";

                if ((original.ToUpper().Contains(selectKeyword.ToUpper()) && original.ToUpper().Contains(fromKeyword.ToUpper())) ||
                    (original.ToUpper().Contains(insertKeyword.ToUpper()) && original.ToUpper().Contains(intoKeyword.ToUpper())) ||
                    (original.ToUpper().Contains(updateKeyword.ToUpper()) && original.ToUpper().Contains(setKeyword.ToUpper()))
                    )
                {
                    return formatter.Format(original);
                }
                return original;
            }
            return original;
        }
    }

    public interface ISQLFormatter
    {
        string Format(string clipText);
    }
}
