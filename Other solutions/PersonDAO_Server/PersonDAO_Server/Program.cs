﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDAO_Server
{
    public class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            server.Listen();
        }
    }
}
