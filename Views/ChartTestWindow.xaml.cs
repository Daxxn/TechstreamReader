using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using TechstreamReader.Models.ChartTest;
using TechstreamReader.ViewModels;

namespace TechstreamReader.Views
{
   /// <summary>
   /// Interaction logic for ChartTestWindow.xaml
   /// </summary>
   public partial class ChartTestWindow : Window
   {
      public ChartTestWindow()
      {
         var mapper = Mappers.Xy<ObservableValue>().X((inst, i) => i).Y((inst, i) => inst.Value);
         Charting.For<ObservableCollection<ObservableValue>>(mapper);

         DataContext = new ChartTestViewModel();

         InitializeComponent();
      }
   }
}
