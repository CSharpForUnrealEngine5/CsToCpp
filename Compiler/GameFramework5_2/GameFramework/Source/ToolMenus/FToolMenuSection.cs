#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenuSection.h")]
public partial struct FToolMenuSection {
// ToolMenuSection
	public string Name;
	public FToolMenuOwner Owner;
	public TArray<FToolMenuEntry> Blocks;
	public FToolMenuInsert InsertPosition;
	public FToolMenuContext Context;
	public UToolMenuSectionDynamic ToolMenuSectionDynamic;
}
