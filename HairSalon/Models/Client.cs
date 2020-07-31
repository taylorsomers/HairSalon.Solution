using System;
using System.ComponentModel;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }

    [DisplayName("Client Name: ")]
    public string ClientName { get; set; }

    public int StylistId { get; set; }

    public virtual Stylist Stylist { get; set; }

    [DisplayName("Hair Color: ")]
    public Color HairColor { get; set; }

    [DisplayName("Preferred Styling Options: ")]
    public Styling[] PreferredStyling { get; set; }
    public Styling StylingFlags => typeof(Styling)?.Aggregate((a, e) => a | e) ?? 0;
  }

  public enum Color
  {
    Black,
    Blond,
    Brown,
    Red
  }

  [Flags]
  public enum Styling
  {
    Color = 1 << 1,
    Curl = 1 << 2,
    Cut = 1 << 4,
    Extensions = 1 << 8,
    Perm = 1 << 16,
    Straighten = 1 << 32,
    Weave = 1 << 64
  }
}