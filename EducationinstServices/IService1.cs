using System.Runtime.Serialization;
using System.ServiceModel;

namespace EducationinstServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        EducationalInfo GetEducationalDetails(string region);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class EducationalInfo
    {
        [DataMember]
        public int BtechCollege { get; set; }
        [DataMember]
        public int MedicalCollege { get; set; }
        [DataMember]
        public int MbaCollege { get; set; }
    }
}
