namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class used for chooser editor details customization</summary>
[CppInclude("ChooserTableEditor.h")]
public partial class UChooserRowDetails : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Chooser</summary>
	public UChooserTable Chooser;
}
