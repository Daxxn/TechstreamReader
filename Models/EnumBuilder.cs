using MVVMLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechstreamReader.Models
{
   public class EnumBuilder : Model
   {
      #region - Fields & Properties
      private Dictionary<string, EnumData> _enumData;
      #endregion

      #region - Constructors
      public EnumBuilder() { }
      #endregion

      #region - Methods

      #endregion

      #region - Full Properties

      public Dictionary<string, EnumData> EnumData
      {
         get { return _enumData; }
         set
         {
            _enumData = value;
            OnPropertyChanged();
         }
      }
      #endregion
   }
}
