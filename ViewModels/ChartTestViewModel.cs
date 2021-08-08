using MVVMLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using LiveCharts;

namespace TechstreamReader.ViewModels
{
   public class ChartTestViewModel : Model
   {
      #region - Fields & Properties
      private ChartValues<double> _values;
      private int _value;
      #region - Commands
      public Command EnterValueCmd { get; set; }
      #endregion
      #endregion

      #region - Constructors
      public ChartTestViewModel()
      {
         Values = new()
         {
            1,
            2,
            3,
            4
         };
         EnterValueCmd = new(o => EnterValue());
      }
      #endregion

      #region - Methods

      #region - Command Methods
      public void EnterValue()
      {
         Values.Add(Value);
      }
      #endregion
      #endregion

      #region - Full Properties
      public ChartValues<double> Values
      {
         get { return _values; }
         set
         {
            _values = value;
            OnPropertyChanged();
         }
      }

      public int Value
      {
         get => _value;
         set
         {
            _value = value;
            OnPropertyChanged();
         }
      }
      #endregion
   }
}
