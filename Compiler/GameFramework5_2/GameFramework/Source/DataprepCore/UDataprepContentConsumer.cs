#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepContentConsumer.h")]
///<summary>Abstract class providing the minimal services required for a DataprepConsumer</summary>
public partial class UDataprepContentConsumer : UObject {
// DataprepContentConsumer
	public bool SetLevelName(string InLevelName,string OutFailureReason) { return default; }
	public bool SetLevelNameAutomated(string InLevelName,string OutFailureReason) { return default; }
	public string GetLevelName() { return default; }
	public bool SetTargetContentFolder(string InTargetContentFolder,string OutFailureReason) { return default; }
	public bool SetTargetContentFolderAutomated(string InTargetContentFolder,string OutFailureReason) { return default; }
	public string GetTargetContentFolder() { return default; }
	public string TargetContentFolder;
	public string LevelName;
}
