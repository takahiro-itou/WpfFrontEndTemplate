
using System;


namespace  ViewCs.Models  {

public  class  SampleModel
{

//========================================================================
//
//    Constructor(s) and Destructor.
//

    //----------------------------------------------------------------
    /**   コンストラクタ。
    **
    **/
    public SampleModel()
    {
        this.m_resultText = "";
    }


//========================================================================
//
//    Public Properties.
//

    //----------------------------------------------------------------
    /**   モデルのタスクを実行する。
    **
    **/
    public  virtual  int
    executeCommand(IProgress<int>  progress)
    {
        string  output = "Hello, World";
        for ( int i = 0; i < output.Length; ++ i ) {
            Me.ResultText += text[i];
            progress.Report(0);
            System.Threading.Thread.Sleep(1000);
        }

        progress.Report(100);
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

//========================================================================
//
//    Member Variables.
//

    private  string     m_resultText;

}   //  End class  SampleModel

}   //  End of namespace  ViewCs.Models
