namespace MyFirstMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string _newLabel = "Welcome to MAUI";
        private string _entryText;
        private Color _labelColor = Colors.Black;
        public string NewLabel
        {
            get => _newLabel;
            set
            {
                _newLabel = value;
                OnPropertyChanged(); // Notify the binding system of changes
            }
        }

        public string EntryText
        {
            get => _entryText;
            set
            {
                if (_entryText != value)
                {
                    _entryText = value;
                    // Update NewLabel when EntryText changes
                }
            }
        }
        public Color LabelColor
        {
            get => _labelColor;
            set
            {
                if (_labelColor != value)
                {
                    _labelColor = value;
                    OnPropertyChanged();
                }
            }
        }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void OnLabelChanged(object sender, EventArgs e)
        {
            NewLabel = EntryText;
            LabelColor = Colors.Red;
        }
        private void OnResetClicked(object sender, EventArgs e)
        {
            NewLabel = "Welcome to MAUI"; // Reset to initial text or empty
            LabelColor = Colors.Black;   // Reset to initial color
            EntryText = string.Empty;    // Clear the entry text
        }
    }

}
