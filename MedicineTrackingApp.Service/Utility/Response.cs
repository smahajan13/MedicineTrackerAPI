using System;
using System.Collections.Generic;
using System.Text;

namespace MedicineTrackingApp.Service
{
    public class Response
    {
        public object Data { get; set; }

        public string Message { get; set; }

        public List<string> Errors { get; set; }
    }
}
