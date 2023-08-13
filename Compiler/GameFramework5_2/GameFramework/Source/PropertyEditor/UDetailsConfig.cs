namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DetailsViewConfig.h")]
public partial class UDetailsConfig : UEditorConfigBase {
	public static UClass StaticClass() {return default;}
	///<summary>Views</summary>
	public TMap<string,FDetailsViewConfig> Views;
}
