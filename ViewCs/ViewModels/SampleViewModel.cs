
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace  ViewCs.ViewModels  {

public  class  SampleViewModel : INotifyPropertyChanged
{

//========================================================================
//
//    Constructor(s) and Destructor.
//

    //----------------------------------------------------------------
    /**   コンストラクタ。
    **
    **/
    public SimpleCommand()
    {
    }


//========================================================================
//
//    Public Properties (Implement Interface).
//

    //----------------------------------------------------------------
    /**
    **
    **/
    public  event PropertyChangedEventHandler?  PropertyChanged;


//========================================================================
//
//    Protected Member Functions.
//

    //----------------------------------------------------------------
    /**
    **
    **/
    protected  virtual  void
    raisePropertyChanged(
            [CallerMemberName]  System.String?  propertyName = null)
    {
        PropertyChanged?.Invoke(
                this, new PropertyChangedEventArgs(propertyName));
    }


}   //  End class  SampleViewModel

}   //  End of namespace  ViewCs.ViewModels
