namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Editor/PropertyEditorTestObject.h")]
public partial class UBlueprintPropertyTestObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ShouldBeHidden</summary>
	public int ShouldBeHidden;
	///<summary>ShouldBeVisible</summary>
	public int ShouldBeVisible;
	///<summary>ObjectA</summary>
	public USoundBase ObjectA;
	///<summary>ObjectB</summary>
	public USoundBase ObjectB;
}
