﻿using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using Otus.Serializer.Demos;

namespace Otus.Serializer
{
    class Program
    {

        static void Main(string[] args)
        {
            var attrDemo = new JsonDemo();
            attrDemo.Show();
        }
    }
}
