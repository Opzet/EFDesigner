//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v3.0.4.7
//     Source:                    https://github.com/msawczyn/EFDesigner
//     Visual Studio Marketplace: https://marketplace.visualstudio.com/items?itemName=michaelsawczyn.EFDesigner
//     Documentation:             https://msawczyn.github.io/EFDesigner/
//     License (MIT):             https://github.com/msawczyn/EFDesigner/blob/master/LICENSE
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Testing
{
   public partial class EntityImplementation: global::Testing.EntityAbstract
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public EntityImplementation(): base()
      {
         Test = "default string";
         Property1 = DateTime.UtcNow;
         Property11 = 3;
         Property12 = true;

         Init();
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Max length = 255, Default value = &quot;default string&quot;
      /// </summary>
      [MaxLength(255)]
      [StringLength(255)]
      public string Test { get; set; }

      /// <summary>
      /// Default value = DateTime.UtcNow
      /// </summary>
      public DateTime? Property1 { get; set; }

      /// <summary>
      /// Default value = 3
      /// </summary>
      public int? Property11 { get; set; }

      /// <summary>
      /// Default value = true
      /// </summary>
      public bool? Property12 { get; set; }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

      public virtual global::Testing.Entity1 Entity1 { get; set; }

   }
}

