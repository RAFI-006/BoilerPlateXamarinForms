using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerPlates.Models
{
  public  class CountryResponse
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public List<State> States { get; set; }
    }


    public partial class State
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
