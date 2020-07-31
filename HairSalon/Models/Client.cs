using System.ComponentModel;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }

    public string ClientName { get; set; }

    public int StylistId { get; set; }

    public virtual Stylist Stylist { get; set; }

    public Color HairColor { get; set; }

    public Styling PreferredStyling { get; set; }
  }

  public enum Color
  {
    black,
    blond,
    brown,
    red
  }

  public enum Styling
  {
    color,
    curl,
    cut,
    extensions,
    perm,
    straighten,
    weave
  }
}