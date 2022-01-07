using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    public string Name { get; set; }
    public Decimal Pay { get; set; }
    public DateTime DateStarted { get; set; }
  }
}