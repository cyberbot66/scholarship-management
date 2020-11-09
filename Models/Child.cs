using Google.Cloud.Firestore;

namespace ScholarshipManagement.Models
{
    [FirestoreData]
    public class Child
    {
        [FirestoreDocumentId]
        public string Id { get; set; }

        [FirestoreProperty]
        public string Avatar { get; set; }
        
        [FirestoreProperty]
        public string FullName { get; set; }

        [FirestoreProperty]
        public string Birthday { get; set; }

        [FirestoreProperty]
        public string BirthPlace { get; set; }

        [FirestoreProperty]
        public string PhoneNumber { get; set; }

        [FirestoreProperty]
        public string Address { get; set; }

        [FirestoreProperty]
        public string AcademicLevel { get; set; }

        [FirestoreProperty]
        public string HealthCondition { get; set; }

        [FirestoreProperty]
        public string FatherFullName { get; set; }

        [FirestoreProperty]
        public string FatherPhoneNumber { get; set; }

        [FirestoreProperty]
        public string MotherFullName { get; set; }

        [FirestoreProperty]
        public string MotherPhoneNumber { get; set; }

        [FirestoreProperty]
        public string ProtectorFullName { get; set; }

        [FirestoreProperty]
        public string ProtectorPhoneNumber { get; set; }
    }
}
