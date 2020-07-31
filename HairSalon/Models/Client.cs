using System.ComponentModel;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }

    public string ClientName { get; set; }

    public int StylistId { get; set; }

    public Color HairColor { get; set; }
  }

  public enum Color
  {
    black,
    blond,
    brown,
    red
  }
}