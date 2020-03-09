namespace OrganizingData
{
    public class ReplaceSubclassWithFields
    {
        public ReplaceSubclassWithFields()
        {
            Person male = new Male();
            var code = male.GetCode();
        }

        abstract class Person
        {
            internal abstract bool IsMale();
            internal abstract char GetCode();
        }

        class Male : Person
        {
            internal override char GetCode()
            {
                return 'M';
            }

            internal override bool IsMale()
            {
                return true;
            }
        }

        class Female : Person
        {
            internal override char GetCode()
            {
                return 'F';
            }

            internal override bool IsMale()
            {
                return false;
            }
        }
    }
}
