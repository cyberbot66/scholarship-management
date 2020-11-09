using Google.Cloud.Firestore;

namespace ScholarshipManagement.Models
{
    [FirestoreData]
    public class EventDetails
    {
        [FirestoreProperty]
        public string EventId { get; set; }

        [FirestoreProperty]
        public string StudentId { get; set; }

        [FirestoreProperty]
        public string Received { get; set; }

        [FirestoreProperty]
        public string ReceivedDate { get; set; }

        [FirestoreProperty]
        public string Signature { get; set; }

        [FirestoreProperty]
        public string AltSignature { get; set; }
    }
}
