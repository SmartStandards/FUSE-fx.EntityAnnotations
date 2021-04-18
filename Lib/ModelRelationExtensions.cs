using System;
using System.Collections.Generic;
using System.Reflection;

namespace System.ComponentModel.DataAnnotations {

  public static class ModelRelationExtensions {

    public static Dictionary<PropertyInfo, Type> GetNavigations(
      this Type extendee,
      bool includePrincipals,
      bool includeLookups,
      bool includeDependents,
      bool includeReferers
    ) {

      Dictionary<PropertyInfo, Type> result = new Dictionary<PropertyInfo, Type>();

      foreach (PropertyInfo prop in extendee.GetProperties()) {
        foreach (Attribute attr in prop.GetCustomAttributes()) {
          if (includePrincipals && attr.GetType() == typeof(PrincipalAttribute)) {
            result[prop] = prop.PropertyType;
          }
          if (includeLookups && attr.GetType() == typeof(LookupAttribute)) {
            result[prop] = prop.PropertyType;
          }
          if (includeDependents && attr.GetType() == typeof(DependentAttribute)) {
            result[prop] = prop.PropertyType;
          }
          if (includeReferers && attr.GetType() == typeof(RefererAttribute)) {
            result[prop] = prop.PropertyType;
          }
        }
      }
 
#if NET46
  //NET46
#endif
#if NET5
  //NET5
#endif

      return result;
    }

  }

}
