#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sessions/MLAdapterLocalDataCollectionSession.h")]
///<summary>Collects data from agents' sensors and writes them to a file for offline processing. Only works with a locally</summary>
public partial class UMLAdapterLocalDataCollectionSession : UMLAdapterSession {
// MLAdapterLocalDataCollectionSession
	public  void OnPawnControllerChanged(APawn InPawn,AController InController) {}
	public FDirectoryPath FilePath;
	public string FileName;
	public bool bPrefixOutputFilenameWithTimestamp;
	public TWeakObjectPtr<UMLAdapterAgent> PlayerControlledAgent;
}
