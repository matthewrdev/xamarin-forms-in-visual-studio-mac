using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.CodeAnalysis;
using Xamarin.Forms;
using XamarinFormsUIs.Helpers;

namespace XamarinFormsUIs.ViewModels
{
    public class ImageAssetBrowserViewModel : BaseViewModel
    {
        private List<TextDocument> _projectImages;
        public List<TextDocument> ProjectImages
        {
            get
            {
                return _projectImages;
            }
            set
            {
                SetProperty(value, ref _projectImages);
            }
        }

        private Solution solution;
        public List<Project> Projects { get; set; }

        public List<string> ProjectNames { get; set; }

        public ImageAssetBrowserViewModel(Solution currentSolution)
        {
            this.solution = currentSolution;
            Projects = solution.Projects.ToList();
            ProjectNames = Projects.Select(p => p.Name).ToList();

            UpdateProjectImagesAsync().ConfigureAwait(false);
        }

        private int _selectedProjectIndex = 0;
        public int SelectedProjectIndex
        {
            get
            {
                return _selectedProjectIndex;
            }
            set
            {
                bool changed = value != SelectedProjectIndex;
                SetProperty(value, ref _selectedProjectIndex);

                if (changed)
                {
                    UpdateProjectImagesAsync().ConfigureAwait(false);
                }
            }
        }

        private Task<bool> UpdateProjectImagesAsync()
        {
            return Task.Run(() =>
            {
                IsBusy = true;
                try
                {
                    var assets = Projects[SelectedProjectIndex].AdditionalDocuments.Where(IsImage).ToList();
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        try
                        {
                            ProjectImages = assets;
                        }
                        catch
                        {

                        }
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    IsBusy = false;
                }

                return true;
            });
        }

        private bool IsImage(TextDocument document)
        {
            var extension = Path.GetExtension(document.FilePath);

            return extension.Equals(".png", StringComparison.InvariantCultureIgnoreCase)
                            || extension.Equals(".jpg", StringComparison.InvariantCultureIgnoreCase)
                            || extension.Equals(".jpeg", StringComparison.InvariantCultureIgnoreCase);
        }

        public ICommand OnImageSelected
        {
            get
            {
                return new Command<SelectedItemChangedEventArgs>((arg) =>
                {
                    var doc = arg.SelectedItem as TextDocument;

                    if (doc != null)
                    {
                        SelectedImage = doc.FilePath;
                    }
                });
            }
        }

        private string _selectedImage;
        public string SelectedImage
        {
            get
            {
                return _selectedImage;
            }
            set
            {
                SetProperty(value, ref _selectedImage);
                try
                {
                    if (File.Exists(SelectedImage))
                    {
                        var size = ImageHelper.GetDimensions(SelectedImage);
                        ImageSize = "Width: " + size.Width + " | Height: " + size.Height;
                    }
                    else
                    {
                        ImageSize = "";
                    }
                }
                catch
                {
                    ImageSize = "";
                }
            }
        }

        private string _imageSize;
        public string ImageSize
        {
            get
            {
                return _imageSize;
            }
            set
            {
                SetProperty(value, ref _imageSize);
            }
        }
    }
}