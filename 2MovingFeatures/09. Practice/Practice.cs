using System.Collections.Generic;
using System.Data;

namespace MovingFeatures
{
    public class Practice
    {
        class Surgeon
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Specialty { get; set; }
            public int AssignedRoomNumber { get; set; }

            public void AssignToRoom(OperationInfo operation)
            {
                if (operation.Room.OperationType != Specialty)
                {
                    return;
                }
                AssignedRoomNumber = operation.Room.Number;
            }
        }

        //Hide delegate, and inline this class to the operation info
        class RoomData
        {
            public int Number { get; set; }
            public string OperationType { get; set; }
        }

        class OperationInfo
        {
            public RoomData Room { get; set; }

            public OperationInfo(string operationType, int number)
            {
                Room = new RoomData
                {
                    Number = number,
                    OperationType = operationType
                };
            }

            public List<Surgeon> GetAvailableSurgeons(DataTable data)
            {
                if (data == null)
                {
                    return new List<Surgeon>();
                }
                var result = new List<Surgeon>();

                for (int i = 0; i < data.Rows.Count; i++)
                {
                    var surgeon = new Surgeon
                    {
                        FirstName = data.Rows[i]["first"].ToString(),
                        LastName = data.Rows[i]["last"].ToString(),
                        Specialty = data.Rows[i]["specialty"].ToString()
                    };
                    result.Add(surgeon);
                }
                return result;
            }


        }
    }
}
