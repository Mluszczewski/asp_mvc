using System;

namespace tech_dot_net_Mluszczewski.Models{
    public class WebsiteContext{
        public Version Version {get; set;}
        public int CopyrightYear {get; set;}
        public bool Approved {get; set;}
    }
}