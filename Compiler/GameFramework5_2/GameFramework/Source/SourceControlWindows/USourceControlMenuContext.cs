namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Source control window menu context providing information for menu extenders.</summary>
[CppInclude("SourceControlMenuContext.h")]
public partial class USourceControlMenuContext : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SelectedFiles</summary>
	public TArray<string> SelectedFiles;
}
