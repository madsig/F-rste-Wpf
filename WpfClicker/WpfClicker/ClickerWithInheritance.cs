using System.Windows;
using System.Windows.Controls;

namespace WpfClicker
{
    class ClickerWithInheritance
        : StackPanel
    {
        private readonly Label _label;
        private int _count;

        public ClickerWithInheritance() : base()
        {
            Orientation = Orientation.Horizontal;
            var button = new Button()
            {
                Content = "Klikk her!"
            };
            button.Click += ButtonClick;
            _label = new Label
            {
                Content = "Trykk på Knappen!"
            };
            Children.Add(button);
            Children.Add(_label);
        }
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }
    }
}
