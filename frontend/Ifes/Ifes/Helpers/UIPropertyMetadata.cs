using Windows.UI.Xaml;

namespace Ifes.Helpers
{
    internal class UIPropertyMetadata : PropertyMetadata
    {
        public UIPropertyMetadata(object defaultValue, PropertyChangedCallback propertyChangedCallback) : base(defaultValue, propertyChangedCallback)
        {
        }
    }
}