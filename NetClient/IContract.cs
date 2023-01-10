using HSchedule.Models;
using System.ServiceModel;

namespace HSchedule.NetClient
{
    /// <summary>
    /// Contract
    /// </summary>
    [ServiceContract]
    interface IContract
    {
        [OperationContract]
        Person ComparePeople(Person person);
    }
}
