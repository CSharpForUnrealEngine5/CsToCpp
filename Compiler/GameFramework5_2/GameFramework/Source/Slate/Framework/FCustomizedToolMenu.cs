namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Framework/MultiBox/ToolMenuBase.h")]
public partial struct FCustomizedToolMenu {
	public string Name;
	public TMap<string,FCustomizedToolMenuEntry> Entries;
	public TMap<string,FCustomizedToolMenuSection> Sections;
	public TMap<string,FCustomizedToolMenuNameArray> EntryOrder;
	public TArray<string> SectionOrder;
}
