#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UTBBaseCommand.h")]
///<summary>UUTBBaseCommand is the base class for any command of the usertoolbox framework.</summary>
public partial class UUTBBaseCommand : UObject {
// UTBBaseCommand
	public string Name;
	public string IconPath;
	public string Tooltip;
	public string Category;
	public bool bShowParameters;
	public FInputChord KeyboardShortcut;
	public UClass UIOverride;
	public UObject UI;
	public bool bIsTransaction;
	public  void ExecuteCommand() {}
	public  void AddObjectToTransaction(UObject Object) {}
	public  void AddObjectsToTransaction(TArray<UObject> Objects) {}
}
