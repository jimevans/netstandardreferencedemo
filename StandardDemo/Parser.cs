using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace StandardDemo
{
    public class Parser
    {
        Dictionary<string, string> dictionary;
        public Parser(string jsonString)
        {
            this.dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);
        }

        public string GetValue(string prop)
        {
            return this.dictionary[prop];
        }
    }
}
