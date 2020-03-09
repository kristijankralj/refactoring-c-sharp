namespace OrganizingData
{
    public class ReplaceTypeCodeWithClass
    {
        public ReplaceTypeCodeWithClass()
        {
            var patient = new Patient(Patient.A);
            int patientGroup = patient.BloodType;
        }

        class Patient
        {
            //blood type constants
            public static int ZERO = 0;
            public static int A = 1;
            public static int B = 2;
            public static int AB = 3;

            private int _bloodType;

            public Patient(int bloodType)
            {
                _bloodType = bloodType;
            }

            public int BloodType
            {
                get
                {
                    return _bloodType;
                }
            }
        }
    }
}
