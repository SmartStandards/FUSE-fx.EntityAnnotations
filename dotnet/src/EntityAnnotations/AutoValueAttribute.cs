namespace System.ComponentModel.DataAnnotations {

  [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
  public class AutoValueAttribute : Attribute {
    public string Algorithm { get; set; }
    public AutoValueAttribute(string algorithm) {
      Algorithm = algorithm;
    }
  }

  public class AutoValueAlgorithm {
    public const string Guid = "Guid";
    public const string Snowflake44 = "Snowflake44";
    public const string Increment = "Increment";
  }

  [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
  public class IncrementAutoValueAttribute : AutoValueAttribute {
    public IncrementAutoValueAttribute(int seed = 1, int increment = 1)
      : base(AutoValueAlgorithm.Increment) {
      Seed = seed;
      Increment = increment;
    }

    public int Seed { get; set; } = 1;
    public int Increment { get; set; } = 1;
  }

  [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
  public class IdentityAttribute : IncrementAutoValueAttribute {
    public IdentityAttribute(int seed = 1, int increment = 1)
      : base(seed, increment) {
      Seed = seed;
      Increment = increment;
    } 
  }

}
