namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editor source control common functionality.</summary>
[CppInclude("SourceControlHelpers.h")]
public partial class USourceControlHelpers : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Determine the name of the current source control provider.</summary>
	public static string CurrentProvider() { return default; }
	///<summary>Determine if there is a source control system enabled</summary>
	public static bool IsEnabled() { return default; }
	///<summary>Quick check if currently set source control provider is enabled and available for use</summary>
	public static bool IsAvailable() { return default; }
	///<summary>Get status text set by SourceControl system if an error occurs regardless whether bSilent is set or not.</summary>
	public static FText LastErrorMsg() { return default; }
	///<summary>Use currently set source control provider to sync a file or directory to the head revision.</summary>
	public static bool SyncFile(string InFile,bool bSilent/*=false*/) { return default; }
	///<summary>Use currently set source control provider to sync files or directories to the head revision.</summary>
	public static bool SyncFiles(TArray<string> InFiles,bool bSilent/*=false*/) { return default; }
	///<summary>Use currently set source control provider to check out a file.</summary>
	public static bool CheckOutFile(string InFile,bool bSilent/*=false*/) { return default; }
	///<summary>Use currently set source control provider to check out specified files.</summary>
	public static bool CheckOutFiles(TArray<string> InFiles,bool bSilent/*=false*/) { return default; }
	///<summary>Use currently set source control provider to check out file or mark it for add.</summary>
	public static bool CheckOutOrAddFile(string InFile,bool bSilent/*=false*/) { return default; }
	///<summary>Use currently set source control provider to check out files or mark them for add.</summary>
	public static bool CheckOutOrAddFiles(TArray<string> InFiles,bool bSilent/*=false*/) { return default; }
	///<summary>Use currently set source control provider to mark a file for add. Does nothing (and returns true) if the file is already under SC</summary>
	public static bool MarkFileForAdd(string InFile,bool bSilent/*=false*/) { return default; }
	///<summary>Use currently set source control provider to mark files for add. Does nothing (and returns true) for any file that is already under SC</summary>
	public static bool MarkFilesForAdd(TArray<string> InFiles,bool bSilent/*=false*/) { return default; }
	///<summary>Use currently set source control provider to remove file from source control and</summary>
	public static bool MarkFileForDelete(string InFile,bool bSilent/*=false*/) { return default; }
	///<summary>Use currently set source control provider to remove files from source control and delete the files.</summary>
	public static bool MarkFilesForDelete(TArray<string> InFiles,bool bSilent/*=false*/) { return default; }
	///<summary>Use currently set source control provider to revert a file regardless whether any changes will be lost or not.</summary>
	public static bool RevertFile(string InFile,bool bSilent/*=false*/) { return default; }
	///<summary>Reverts the provided files then reloads packages.</summary>
	public static bool RevertAndReloadPackages(TArray<string> InPackagesToRevert,bool bRevertAll/*=false*/,bool bReloadWorld/*=false*/) { return default; }
	///<summary>Use currently set source control provider to revert files regardless whether any changes will be lost or not.</summary>
	public static bool RevertFiles(TArray<string> InFiles,bool bSilent/*=false*/) { return default; }
	///<summary>Use currently set source control provider to revert a file provided no changes have been made.</summary>
	public static bool RevertUnchangedFile(string InFile,bool bSilent/*=false*/) { return default; }
	///<summary>Use currently set source control provider to revert files provided no changes have been made.</summary>
	public static bool RevertUnchangedFiles(TArray<string> InFiles,bool bSilent/*=false*/) { return default; }
	///<summary>Use currently set source control provider to check in a file.</summary>
	public static bool CheckInFile(string InFile,string InDescription,bool bSilent/*=false*/,bool bKeepCheckedOut/*=false*/) { return default; }
	///<summary>Use currently set source control provider to check in specified files.</summary>
	public static bool CheckInFiles(TArray<string> InFiles,string InDescription,bool bSilent/*=false*/,bool bKeepCheckedOut/*=false*/) { return default; }
	///<summary>Use currently set source control provider to copy a file.</summary>
	public static bool CopyFile(string InSourceFile,string InDestFile,bool bSilent/*=false*/) { return default; }
	///<summary>Use currently set source control provider to query a file&#39;s source control state.</summary>
	public static FSourceControlState QueryFileState(string InFile,bool bSilent/*=false*/) { return default; }
	///<summary>Delegate to broadcast FileState upon AsyncQueryFileState completion</summary>
	public void FQueryFileStateDelegate(FSourceControlState FileStateOut) {}
	///<summary>Query the source control state of the specified file, asynchronously.</summary>
	public static void AsyncQueryFileState(FQueryFileStateDelegate FileStateCallback,string InFile,bool bSilent/*=false*/) {}
}
