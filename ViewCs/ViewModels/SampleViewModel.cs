
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;

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
        this.m_progress = new System.Progress<int>(updateProgress);
        this.m_trgModel = model;

        this.m_runTaskCommand   = new SimpleCommand(
                _ => runModelTaskAsync(), _ => canRunTask() );
        this.m_returnCode   = 0;
    }


//========================================================================
//
//    Public Properties.
//

    //----------------------------------------------------------------
    /**
    **
    **/
    public  event PropertyChangedEventHandler?  PropertyChanged;

    public  string
    ResultText  {
        get { return  this.m_trgModel.ResultText; }
        set { this.m_trgModel.ResultText = value; }
    }

    public  int
    ReturnCode  {
        get {
            return  this.m_returnCode;
        }
        private set {
            this.m_returnCode = value;
        }
    }


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
    /**   モデルのタスクを非同期で実行する。
    **
    **/
    public  async  void
    runModelTaskAsync()
    {
        Task<int>  task = Task.Run<int>(
            () => this.m_trgModel.runTask(this.m_progress));
        int  result = await task;
        this.ReturnCode = result;
        this.ResultText = this.m_trgModel.ResultText;
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


    //----------------------------------------------------------------
    /**
    **
    **/
    protected  virtual  void
    updateProgress(int progressValue)
    {
    }


//========================================================================
//
//    Member Variables.
//

    private  readonly   System.IProgress<int>   m_progress;
    private  readonly   SampleModel             m_trgModel;

    private  readonly   SimpleCommand           m_runTaskCommand;

    private  int    m_returnCode;

}   //  End class  SampleViewModel

}   //  End of namespace  ViewCs.ViewModels
