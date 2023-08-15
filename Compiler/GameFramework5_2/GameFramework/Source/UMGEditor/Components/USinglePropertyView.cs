namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The single property view allows you to display the value of an object&#39;s property.</summary>
[CppInclude("Components/SinglePropertyView.h")]
public partial class USinglePropertyView : UPropertyViewBase {
	public static UClass StaticClass() {return default;}
	///<summary>The name of the property to display.</summary>
	public FName PropertyName;
	///<summary>Override for the property name that will be displayed instead of the property name.</summary>
	public FText NameOverride;
	///<summary>GetPropertyName</summary>
	public FName GetPropertyName() { return default; }
	///<summary>SetPropertyName</summary>
	public void SetPropertyName(FName NewPropertyName) {}
	///<summary>GetNameOverride</summary>
	public FText GetNameOverride() { return default; }
	///<summary>SetNameOverride</summary>
	public void SetNameOverride(FText NewPropertyName) {}
}
