#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UUTBBaseCommand is the base class for any command of the usertoolbox framework.</summary>
[CppInclude("UTBBaseCommand.h")]
public partial class UUTBBaseCommand : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The name of the command</summary>
	public string Name;
	///<summary>The icon path for the command</summary>
	public string IconPath;
	///<summary>Tooltip</summary>
	public string Tooltip;
	///<summary>Category</summary>
	public string Category;
	///<summary>bShowParameters</summary>
	public bool bShowParameters;
	///<summary>KeyboardShortcut</summary>
	public FInputChord KeyboardShortcut;
	///<summary>UIOverride</summary>
	public UClass UIOverride;
	///<summary>UI</summary>
	public UObject UI;
	///<summary>bIsTransaction</summary>
	public bool bIsTransaction;
	///<summary>ExecuteCommand</summary>
	public  void ExecuteCommand() {}
	///<summary>AddObjectToTransaction</summary>
	public  void AddObjectToTransaction(UObject Object) {}
	///<summary>AddObjectsToTransaction</summary>
	public  void AddObjectsToTransaction(TArray<UObject> Objects) {}
}
