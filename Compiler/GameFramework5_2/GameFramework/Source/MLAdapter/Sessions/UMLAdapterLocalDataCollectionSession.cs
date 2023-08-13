namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Collects data from agents&#39; sensors and writes them to a file for offline processing. Only works with a locally</summary>
[CppInclude("Sessions/MLAdapterLocalDataCollectionSession.h")]
public partial class UMLAdapterLocalDataCollectionSession : UMLAdapterSession {
	public static UClass StaticClass() {return default;}
	///<summary>OnPawnControllerChanged</summary>
	public virtual void OnPawnControllerChanged(APawn InPawn,AController InController) {}
	///<summary>FilePath</summary>
	public FDirectoryPath FilePath;
	///<summary>FileName</summary>
	public string FileName;
	///<summary>bPrefixOutputFilenameWithTimestamp</summary>
	public bool bPrefixOutputFilenameWithTimestamp;
	///<summary>PlayerControlledAgent</summary>
	public TWeakObjectPtr<UMLAdapterAgent> PlayerControlledAgent;
}
