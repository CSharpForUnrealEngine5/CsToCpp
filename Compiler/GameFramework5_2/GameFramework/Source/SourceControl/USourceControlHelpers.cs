#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceControlHelpers.h")]
///<summary>Editor source control common functionality.</summary>
public partial class USourceControlHelpers : UObject {
// SourceControlHelpers
	public string CurrentProvider() { return default; }
	public bool IsEnabled() { return default; }
	public bool IsAvailable() { return default; }
	public string LastErrorMsg() { return default; }
	public bool SyncFile(string InFile,bool bSilent/*=false*/) { return default; }
	public bool SyncFiles(TArray<string> InFiles,bool bSilent/*=false*/) { return default; }
	public bool CheckOutFile(string InFile,bool bSilent/*=false*/) { return default; }
	public bool CheckOutFiles(TArray<string> InFiles,bool bSilent/*=false*/) { return default; }
	public bool CheckOutOrAddFile(string InFile,bool bSilent/*=false*/) { return default; }
	public bool CheckOutOrAddFiles(TArray<string> InFiles,bool bSilent/*=false*/) { return default; }
	public bool MarkFileForAdd(string InFile,bool bSilent/*=false*/) { return default; }
	public bool MarkFilesForAdd(TArray<string> InFiles,bool bSilent/*=false*/) { return default; }
	public bool MarkFileForDelete(string InFile,bool bSilent/*=false*/) { return default; }
	public bool MarkFilesForDelete(TArray<string> InFiles,bool bSilent/*=false*/) { return default; }
	public bool RevertFile(string InFile,bool bSilent/*=false*/) { return default; }
	public bool RevertAndReloadPackages(TArray<string> InPackagesToRevert,bool bRevertAll/*=false*/,bool bReloadWorld/*=false*/) { return default; }
	public bool RevertFiles(TArray<string> InFiles,bool bSilent/*=false*/) { return default; }
	public bool RevertUnchangedFile(string InFile,bool bSilent/*=false*/) { return default; }
	public bool RevertUnchangedFiles(TArray<string> InFiles,bool bSilent/*=false*/) { return default; }
	public bool CheckInFile(string InFile,string InDescription,bool bSilent/*=false*/,bool bKeepCheckedOut/*=false*/) { return default; }
	public bool CheckInFiles(TArray<string> InFiles,string InDescription,bool bSilent/*=false*/,bool bKeepCheckedOut/*=false*/) { return default; }
	public bool CopyFile(string InSourceFile,string InDestFile,bool bSilent/*=false*/) { return default; }
	public FSourceControlState QueryFileState(string InFile,bool bSilent/*=false*/) { return default; }
	public void FQueryFileStateDelegate(FSourceControlState FileStateOut) {}
	public void AsyncQueryFileState(FQueryFileStateDelegate FileStateCallback,string InFile,bool bSilent/*=false*/) {}
}
