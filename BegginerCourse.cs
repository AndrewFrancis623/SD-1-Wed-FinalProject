﻿using System.Diagnostics;

namespace FinalProject
{

    public class BegginerCourse
    {
        private string name;
        private string skilllevel;
        private string phonenumber;
        private string address;
        private string website;

        public BegginerCourse(string name, string skilllevel, string phonenumber, string address, string website)
        {
            this.name = name;
            this.skilllevel = skilllevel;
            this.phonenumber = phonenumber;
            this.address = address;
            this.website = website;
        }

        public string Name { get { return name; } }
        public string Skilllevel { get { return skilllevel; } }
        public string Phonenumber { get { return phonenumber; } }
        public string Address { get { return address; } }
        public string Website { get { return website; } }

        List<BegginerCourse> GolfCourseList = new List<BegginerCourse>();


    }   
}