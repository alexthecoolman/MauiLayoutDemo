//#define flexlayoutpage
//#define absolutelayoutpage
//#define bindablelayoutpage
//#define customlayoutpage
//#define gridlayoutpage
#define dashboarLayout

namespace FlexLayoutDemo;

public partial class App : Application
{
	public App()
	{
		this.InitializeComponent();
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
#if dashboarLayout
        this.MainPage = new DashboardLayoutPage();
#endif

    }
}
