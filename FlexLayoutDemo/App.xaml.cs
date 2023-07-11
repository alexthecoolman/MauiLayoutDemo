//#define flexlayoutpage
//#define absolutelayoutpage
//#define bindablelayoutpage
//#define customlayoutpage
#define gridlayoutpage

namespace FlexLayoutDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
#if flexlayoutpage
        MainPage = new FlexLayoutPage();
#endif

#if absolutelayoutpage
       MainPage = new AbsoluteLayoutPage();
#endif

#if bindablelayoutpage
      MainPage = new BindableLayoutPage();
#endif

#if customlayoutpage
        MainPage = new CustomLayoutPage(); 
#endif
#if gridlayoutpage
        MainPage = new GridPage();
#endif

    }
}
