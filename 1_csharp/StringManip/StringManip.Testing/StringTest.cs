using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace StringManip.Testing
{
  public class StringTest
  {
    private string test = "The quick brown fox jumps over the lazy dog"
    [Fact]
    public void ListReversed()
    {
      var expected = "god yzal eht revo spmuj xof nworb kciuq ehT";

      Assert.True(expected == actual);
    }
  }
}
