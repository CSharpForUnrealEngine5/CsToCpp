#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceControlHelpers.h")]
///<summary>Editor source control common functionality.</summary>
public partial class USourceControlHelpers : UObject {
// SourceControlHelpers
	public static string CurrentProvider() { return default; }
	public static bool IsEnabled() { return default; }
	public static bool IsAvailable() { return default; }
	public static string LastErrorMsg() { return default; }
	public static bool SyncFile(string InFile,bool bSilent/*=false*/) { return default; }
	public static bool SyncFiles(TArray<string> InFiles,bool bSilent/*=false*/) { return default; }
	public static bool CheckOutFile(string InFile,bool bSilent/*=false*/) { return default; }
	public static bool CheckOutFiles(TArray<string> InFiles,bool bSilent/*=false*/) { return default; }
	public static bool CheckOutOrAddFile(string InFile,bool bSilent/*=false*/) { return default; }
	public static bool CheckOutOrAddFiles(TArray<string> InFiles,bool bSilent/*=false*/) { return default; }
	public static bool MarkFileForAdd(string InFile,bool bSilent/*=false*/) { return default; }
	public static bool MarkFilesForAdd(TArray<string> InFiles,bool bSilent/*=false*/) { return default; }
	public static bool MarkFileForDelete(string InFile,bool bSilent/*=false*/) { return default; }
	public static bool MarkFilesForDelete(TArray<string> InFiles,bool bSilent/*=false*/) { return default; }
	public static bool RevertFile(string InFile,bool bSilent/*=false*/) { return default; }
	public static bool RevertAndReloadPackages(TArray<string> InPackagesToRevert,bool bRevertAll/*=false*/,bool bReloadWorld/*=false*/) { return default; }
	public static bool RevertFiles(TArray<string> InFiles,bool bSilent/*=false*/) { return default; }
	public static bool RevertUnchangedFile(string InFile,bool bSilent/*=false*/) { return default; }
	public static bool RevertUnchangedFiles(TArray<string> InFiles,bool bSilent/*=false*/) { return default; }
	public static bool CheckInFile(string InFile,string InDescription,bool bSilent/*=false*/,bool bKeepCheckedOut/*=false*/) { return default; }
	public static bool CheckInFiles(TArray<string> InFiles,string InDescription,bool bSilent/*=false*/,bool bKeepCheckedOut/*=false*/) { return default; }
	public static bool CopyFile(string InSourceFile,string InDestFile,bool bSilent/*=false*/) { return default; }
	public static FSourceControlState QueryFileState(string InFile,bool bSilent/*=false*/) { return default; }
	public  void FQueryFileStateDelegate(FSourceControlState FileStateOut) {}
	public static void AsyncQueryFileState(FQueryFileStateDelegate FileStateCallback,string InFile,bool bSilent/*=false*/) {}
}
