namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Custom Color Object</summary>
[CppInclude("CurveEditorSettings.h")]
public partial struct FCustomColorForChannel {
	public TSoftObjectPtr<UClass> Object;
	public string PropertyName;
	public FLinearColor Color;
}
