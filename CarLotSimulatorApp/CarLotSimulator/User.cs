using System;
namespace CarLotSimulator
{//Class test from get set slideshow
    public class User
    {
        public User()
        {
        }

        private string name = "Suresh Dasari";

        public string Name
        {
            get
            {
                return name.ToUpper();
            }
            set
            {
                name = value;
            }
        }

        public string Name2 { get; set; }

    }
}
