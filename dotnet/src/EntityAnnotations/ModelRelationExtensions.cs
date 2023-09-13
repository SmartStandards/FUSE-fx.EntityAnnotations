using System;
using System.Collections.Generic;
using System.Reflection;

namespace System.ComponentModel.DataAnnotations {

  public static class ModelRelationExtensions {

    /// <summary>
    /// (from 'FUSE-fx.EntityAnnotations')
    /// </summary>
    /// <param name="extendee"></param>
    /// <param name="includePrincipals"></param>
    /// <param name="includeLookups"></param>
    /// <param name="includeDependents"></param>
    /// <param name="includeReferrers"></param>
    /// <returns></returns>
    public static Dictionary<PropertyInfo, Type> GetNavigations(
      this Type extendee,
      bool includePrincipals,
      bool includeLookups,
      bool includeDependents,
      bool includeReferrers
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
          if (includeReferrers && (attr.GetType() == typeof(ReferrerAttribute))) {
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
