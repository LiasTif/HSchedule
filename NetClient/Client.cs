using System.Windows;
using System;
using System.ServiceModel;
using HSchedule.Models;

namespace HSchedule.NetClient
{
    public class Client
    {
        // expect incoming events at this location
        Uri adress = new Uri("http://localhost:8000/HSchedule_Host");

        // instructions for exchanging messages
        BasicHttpBinding binding = new BasicHttpBinding();

        // a link to an instance of ChannelFactory<T>, where T is the contract
        ChannelFactory<IContract> factory;

        // link to channel (proxy)
        IContract channel;

        public bool Compare(Person person)
        {
            try
            {
                if (factory == null)
                {
                    // creating an instance of ChannelFactory<T>, where T is the contract
                    factory = new ChannelFactory<IContract>(binding, new EndpointAddress(adress));

                    // using the factory to create a channel (proxy)
                    channel = factory.CreateChannel();
                }

                if (factory != null && channel != null)
                {
                    if (channel.ComparePeople(person) is Person)
                    {
                        UserBuffer.ActualUser = person;
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
