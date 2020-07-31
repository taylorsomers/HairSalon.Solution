using System.ComponentModel;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }

    public string ClientName { get; set; }

    public int StylistId { get; set; }

    public virtual Stylist Stylist { get; set; }

    [DisplayName("Hair Color")]
    public Color HairColor { get; set; }

    public Styling PreferredStyling { get; set; }
  }

  public enum Color
  {
    Black,
    Blond,
    Brown,
    Red
  }

  public enum Styling
  {
    Color,
    Curl,
    Cut,
    Extensions,
    Perm,
    Straighten,
    Weave
  }
}