using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace FileDateEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<FileGridModel> _selectedFiles = new ObservableCollection<FileGridModel>();

        public MainWindow()
        {
            InitializeComponent();
            FilesGrid.ItemsSource = _selectedFiles;
        }

        private void BtnSelectFiles_OnClick(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog { Multiselect = true };
            bool? result = openFileDialog.ShowDialog();

            if (null != result && result.Value)
            {
                var files = openFileDialog.FileNames;
                if (files.Any())
                {
                    foreach (var f in files)
                    {
                        var c = File.GetCreationTime(f);
                        var a = File.GetLastAccessTime(f);
                        var w = File.GetLastWriteTime(f);
                        var m = new FileGridModel(f, c, a, w);

                        if (_selectedFiles.All(p => p.Path != f))
                        {
                            _selectedFiles.Add(m);
                        }
                    }
                }
            }

            if (_selectedFiles.Any())
            {
                BtnCommitEdit.IsEnabled = true;
            }
        }

        private void BtnClearFiles_OnClick(object sender, RoutedEventArgs e)
        {
            _selectedFiles = new ObservableCollection<FileGridModel>();
            FilesGrid.ItemsSource = null;
            BtnCommitEdit.IsEnabled = false;
        }

        private void BtnCommitEdit_OnClick(object sender, RoutedEventArgs e)
        {
            int failed = 0;
            string errMessage = string.Empty;

            if (_selectedFiles.Any())
            {
                foreach (var f in _selectedFiles)
                {
                    try
                    {
                        File.SetCreationTime(f.Path, f.CreationTime);
                        File.SetLastAccessTime(f.Path, f.LastAccessTime);
                        File.SetLastWriteTime(f.Path, f.LastWriteTime);
                    }
                    catch (Exception ex)
                    {
                        failed++;
                        errMessage += ex.Message + Environment.NewLine;
                    }
                }
            }

            if (failed > 0)
            {
                MessageBox.Show(errMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Done!", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }

    internal class FileGridModel
    {
        public string Path { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime LastAccessTime { get; set; }

        public DateTime LastWriteTime { get; set; }

        public FileGridModel(string path, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime)
        {
            Path = path;
            CreationTime = creationTime;
            LastAccessTime = lastAccessTime;
            LastWriteTime = lastWriteTime;
        }
    }
}
