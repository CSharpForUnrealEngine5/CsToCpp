namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Framework/MultiBox/ToolMenuBase.h")]
public partial struct FCustomizedToolMenu {
	public FName Name;
	public TMap<FName,FCustomizedToolMenuEntry> Entries;
	public TMap<FName,FCustomizedToolMenuSection> Sections;
	public TMap<FName,FCustomizedToolMenuNameArray> EntryOrder;
	public TArray<FName> SectionOrder;
	public TArray<FName> SuppressExtenders;
}
