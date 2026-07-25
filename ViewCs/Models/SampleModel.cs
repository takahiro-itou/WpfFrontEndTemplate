
using System;


namespace  ViewCs.Models  {

public  class  SampleModel
{

    //----------------------------------------------------------------
    /**   モデルのタスクを実行する。
    **
    **/
    public  virtual  int
    runTask(IProgress<int>  progress)
    {
        executeCommand();
        return ( 0 );
    }


//========================================================================
//
//    Properties.
//

    public  string
    ResultText  {
        get { return  this.m_resultText; }
        set { this.m_resultText = value; }
    }


//========================================================================
//
//    Protected Member Functions.
//

    //----------------------------------------------------------------
    /**   指定したコマンドを実行する。
    **
    **/
    protected  virtual  void
    executeCommand()
    {
        this.ResultText = "Hello, World";
        System.Threading.Thread.Sleep(5000);
    }


//========================================================================
//
//    Member Variables.
//

    private  string     m_resultText;

}   //  End class  SampleModel

}   //  End of namespace  ViewCs.Models
