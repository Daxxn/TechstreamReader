using CSVParserLibrary.Techstream;
using Microsoft.Win32;
using MVVMLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;

namespace TechstreamReader.ViewModels
{
   public class MainViewModel : ViewModel
   {
      #region - Fields & Properties
      private ObservableCollection<FFDFile> _ffdFiles;
      private FFDFile _selectedFile;
      #region - Commands
      public Command ParseTestCmd { get; set; }
      public Command OpenFileCmd { get; set; }
      #endregion
      #endregion

      #region - Constructors
      public MainViewModel()
      {
         ParseTestCmd = new(o => ParseTest());
         OpenFileCmd = new(o => OpenFile());
      }
      #endregion

      #region - Methods

      #region - Command Methods
      private void ParseTest()
      {
         FFDFiles = new(new FFDFile[] { FFDManager.ParseFile(
            @"D:\Automotive Stuff\Techstream Data\FFDs\JTDZN3EU5EJ015259_FFD\FFD_6-11-21_1.csv"
         ) });
      }

      private void OpenFile()
      {
         try
         {
            OpenFileDialog dialog = new()
            {
               Multiselect = true,
               Title = "Open Freeze Frame Data File",
            };

            if (dialog.ShowDialog() == true)
            {
               var files = dialog.FileNames;

               FFDFiles = new();

               foreach (var file in files)
               {
                  FFDFiles.Add(FFDManager.ParseFile(file));
               }
            }
         }
         catch (Exception e)
         {
            MessageBox.Show(e.Message, "Error");
         }
      }
      #endregion
      #endregion

      #region - Full Properties
      public ObservableCollection<FFDFile> FFDFiles
      {
         get { return _ffdFiles; }
         set
         {
            _ffdFiles = value;
            OnPropertyChanged();
         }
      }

      public FFDFile SelectedFile
      {
         get { return _selectedFile; }
         set
         {
            _selectedFile = value;
            OnPropertyChanged();
         }
      }
      #endregion
   }
}
