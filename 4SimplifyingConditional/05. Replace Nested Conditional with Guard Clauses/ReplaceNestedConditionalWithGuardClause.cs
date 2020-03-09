namespace SimplifyingConditional
{
    public class ReplaceNestedConditionalWithGuardClause
    {
        public double GetInterestRate(ClientType clientType)
        {
            double result;
            if (clientType == ClientType.Business)
            {
                result = 0.05;
            }
            else
            {
                if (clientType == ClientType.ExistingClient)
                {
                    result = 0.02;
                }
                else
                {
                    result = 0.03;
                }
            }
            return result;
        }
    }

    public enum ClientType
    {
        Business,
        ExistingClient,
        NewClient
    }
}
