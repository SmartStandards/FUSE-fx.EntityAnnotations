namespace System.ComponentModel.DataAnnotations {

  /// <summary>
  /// Defines, that this entity has an OUTBOUND dependency to another entity which represents the PRINCIPAL.
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