using Google.Cloud.Firestore;

namespace ScholarshipManagement.Models
{
    [FirestoreData]
    public class Event
    {
        [FirestoreProperty]
        public string EventId { get; set; }

        [FirestoreProperty]
        public string NgayNhanTien { get; set; }

        [FirestoreProperty]
        public string NgayPhatTien { get; set; }
    }
}
