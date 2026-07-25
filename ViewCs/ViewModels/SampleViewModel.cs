
using System.ComponentModel;
using System.Runtime.CompilerServices;

using ViewCs.Commands;
using ViewCs.Models;


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
    public SampleViewModel(
            SampleModel model)
    {
        this.m_trgModel = model;

        this.m_runTaskCommand   = new SimpleCommand(
                _ => runModelTaskAsync(), _ => canRunTask() );
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
//    Public Member Functions.
//

    //----------------------------------------------------------------
    /**
    **
    **/
    public  virtual  bool
    canRunTask()
    {
        return ( true );
    }

    //----------------------------------------------------------------
    /**
    **
    **/
    public  async  void
    runModelTaskAsync()
    {
    }


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


//========================================================================
//
//    Member Variables.
//

    private  readonly   SampleModel     m_trgModel;

}   //  End class  SampleViewModel

}   //  End of namespace  ViewCs.ViewModels
