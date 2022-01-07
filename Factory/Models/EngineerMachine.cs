namespace Factory.Models
{
  public class EngineerMachine
  {
    public int EngineerMachineId { get; set; }
    public int EngineerId { get; set; }
    public int MachineId { get; set; }
    public virtual Engineer Engineers { get; set; }
    public virtual Machine machine { get; set; }
  }
}