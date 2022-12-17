using Balta.NotificationContext;

namespace Balta.SharedContext
{
  public abstract class Base : Notifiable
  {
    public Base()
    {
      Id = Guid.NewGuid(); // SPOF -> Single Point od Failure
    }
    public Guid Id { get; set; }
  }
}