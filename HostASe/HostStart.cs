﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Host
{
    class HostStart
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(WOZAP.Service)))
            {
				host.Open();
                Console.WriteLine("Хост стартовал!");
                Console.ReadLine();
            }
        }
    }
}
