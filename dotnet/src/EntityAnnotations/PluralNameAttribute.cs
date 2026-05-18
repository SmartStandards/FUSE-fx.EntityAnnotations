namespace System.ComponentModel.DataAnnotations {

  /// <summary>
  /// Defines the correct spelling of the plural name of the entity class
  /// (from 'FUSE-fx.EntityAnnotations')
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
  public class PluralNameAttribute : Attribute {

    public PluralNameAttribute(string pluralName) {
      PluralName = pluralName;
    }

    public string PluralName { get; }
  }

}