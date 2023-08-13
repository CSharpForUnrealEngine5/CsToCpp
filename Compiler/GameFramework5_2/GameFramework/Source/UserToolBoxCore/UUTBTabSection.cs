namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UTBBaseTab.h")]
public partial class UUTBTabSection : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The name of the section</summary>
	public string SectionName;
	///<summary>The list of command</summary>
	public TArray<UUTBBaseCommand> Commands;
}
