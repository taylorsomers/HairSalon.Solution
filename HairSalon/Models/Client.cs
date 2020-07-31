using System;
using System.ComponentModel;
using System.Linq;

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
  }

  public enum Color
  {
    Black,
    Blond,
    Brown,
    Red
  }
}