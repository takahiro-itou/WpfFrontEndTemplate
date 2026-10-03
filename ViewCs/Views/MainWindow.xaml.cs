
using System.Windows;

using ViewCs;


namespace  ViewCs.Views  {

//========================================================================
//
//    MainWindow  class
//

public  partial class  MainWindow : Window
{

//========================================================================
//
//    Constructor(s) and Destructor.
//

//----------------------------------------------------------------
/**   デフォルトコンストラクタ。
**
**/
public  MainWindow()
{
    InitializeComponent();

    this.Loaded += MainWindow_Loaded;

    this.m_taskModel = new Models.SampleModel();
    this.m_viewModel = new ViewModels.SampleViewModel(this.m_taskModel);

    this.DataContext = this.m_viewModel;
}


//========================================================================
//
//    Event Handlers.
//

private  void
MainWindow_Loaded(object sender, RoutedEventArgs e)
{
    string  customIcon  = Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory,
        "Resources\MainWindow.ico");
    if ( File.Exists(customIcon) ) {
        try {
            this.Icon = new BitmapImage(
                    new Uri(customIcon, UriKind.Absolute));
        } catch ( Exception ex ) {
            System.Diagnostics.Debug.WriteLine(
                $"Failed custom icon: {ex.Message}");
        }
    ]
}

//========================================================================
//
//    Member Variables.
//

private   Models.SampleModel            m_taskModel;
private   ViewModels.SampleViewModel    m_viewModel;


}   //  End class  MainWindow

}   //  End of namespace  ViewCs.Views
