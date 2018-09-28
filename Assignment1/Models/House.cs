using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1.Models
{
    public class House
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public int LotSize { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public House(int value, int lotSize, string address, string city, string state, string postalCode,int id)
        {
            this.Id = id;
            this.Value = value;
            this.LotSize = lotSize;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
        }
    }
}