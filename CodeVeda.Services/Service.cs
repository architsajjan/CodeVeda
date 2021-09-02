using System;
using CodeVeda.Interfaces;

namespace CodeVeda.Services
{
    public class Service : IService
    {
        public string PrintMessage(string messasge = "Hello World!")
        {
            return messasge;
        }
    }
}
