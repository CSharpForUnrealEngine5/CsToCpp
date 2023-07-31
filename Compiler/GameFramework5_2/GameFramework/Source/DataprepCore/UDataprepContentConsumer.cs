#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Abstract class providing the minimal services required for a DataprepConsumer</summary>
[CppInclude("DataprepContentConsumer.h")]
public partial class UDataprepContentConsumer : UObject {
	///<summary>Sets the name of the level the consumer should move objects to if applicable.</summary>
	public  bool SetLevelName(string InLevelName,string OutFailureReason) { return default; }
	///<summary>Sets the name of the level the consumer should move objects to if applicable.</summary>
	public  bool SetLevelNameAutomated(string InLevelName,string OutFailureReason) { return default; }
	///<summary>GetLevelName</summary>
	public  string GetLevelName() { return default; }
	///<summary>Sets the path of the package the consumer should move assets to if applicable.</summary>
	public  bool SetTargetContentFolder(string InTargetContentFolder,string OutFailureReason) { return default; }
	///<summary>Sets the path of the package the consumer should move assets to if applicable.</summary>
	public  bool SetTargetContentFolderAutomated(string InTargetContentFolder,string OutFailureReason) { return default; }
	///<summary>GetTargetContentFolder</summary>
	public  string GetTargetContentFolder() { return default; }
	///<summary>TargetContentFolder</summary>
	public string TargetContentFolder;
	///<summary>LevelName</summary>
	public string LevelName;
}
