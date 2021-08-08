using MVVMLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace TechstreamReader.Models.ChartTest
{
   public class ObservableValue : Model
   {
      #region - Fields & Properties
      private double _value;
      #endregion

      #region - Constructors
      public ObservableValue() { }
      #endregion

      #region - Methods

      #region - Command Methods

      #endregion
      #endregion

      #region - Full Properties

      public double Value
      {
         get { return _value; }
         set
         {
            _value = value;
            OnPropertyChanged();
         }
      }
      #endregion
   }
}
