﻿namespace DemoAPI
{
    public interface IEmployee
    { 
        public string? Name { get; set; }
        public string Description { get; set; }

    }
    public class Employee : IEmployee
    {
        public string? Name { get; set; }
        public string Description { get; set; }
    }
}
