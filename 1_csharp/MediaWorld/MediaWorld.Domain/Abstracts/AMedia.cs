namespace MediaWorld.Domain.Abstracts
{
  public abstract class AMedia
  {
    // C# 8.0 or higher
    // public string Title { get; set; } = "C#";

    public string Title { get; }

    protected AMedia()
    {
      Title = "Revature";
    }
  }
}
