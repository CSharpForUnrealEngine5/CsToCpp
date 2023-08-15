namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenuSection.h")]
public partial struct FToolMenuSection {
	public FName Name;
	public FToolMenuOwner Owner;
	public TArray<FToolMenuEntry> Blocks;
	public FToolMenuInsert InsertPosition;
	public FToolMenuContext Context;
	public UToolMenuSectionDynamic ToolMenuSectionDynamic;
}
