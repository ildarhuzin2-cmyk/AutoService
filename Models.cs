using System;

namespace AutoService
{
    public class Car
    {
        public string Model { get; set; }
        public string Number { get; set; }

        public Car(string model, string number)
        {
            Model = model;
            Number = number;
        }
    }

    public class Client
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public Client(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
    }

    public class Appointment
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public Car Car { get; set; }
        public DateTime DateTime { get; set; }

        public Appointment(int id, Client client, Car car, DateTime dt)
        {
            Id = id;
            Client = client;
            Car = car;
            DateTime = dt;
        }
    }
}