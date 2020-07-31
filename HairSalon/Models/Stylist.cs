using System.Collections.Generic;
using System.ComponentModel;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }

    public int StylistId { get; set; }

    [DisplayName("Stylist Name: ")]
    public string StylistName { get; set; }

    public virtual ICollection<Client> Clients { get; set; }
  }
}