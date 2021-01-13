using System;
using System.Collections.Generic;
using System.Text;

namespace Blogdulich.Web.Models.Contact
{
  public  class UpdateContactResult
    {
        public int ContactId { get; set; }
        public string Message { get; set; }
        public string Result { get; set; }
    }
}
