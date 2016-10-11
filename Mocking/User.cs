using System.Text;
using System;


namespace Mocking
{ 
   public enum Rights
    {
        Full,
        None,
    }
    
   public  class User
    {
        public String Password { get; set; }
        public String UserName { get; set; }
        public Rights Rights { get; set; }
        public int NumMessagesCreated { get; internal set; }

        public User()
        {


        }

        public string ViewAllEmployees()
        {
            return "Here is the list";
        }
    }
}