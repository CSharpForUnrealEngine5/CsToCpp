#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The single property view allows you to display the value of an object&#39;s property.</summary>
[CppInclude("Components/SinglePropertyView.h")]
public partial class USinglePropertyView : UPropertyViewBase {
	///<summary>The name of the property to display.</summary>
	public string PropertyName;
	///<summary>Override for the property name that will be displayed instead of the property name.</summary>
	public string NameOverride;
	///<summary>GetPropertyName</summary>
	public  string GetPropertyName() { return default; }
	///<summary>SetPropertyName</summary>
	public  void SetPropertyName(string NewPropertyName) {}
	///<summary>GetNameOverride</summary>
	public  string GetNameOverride() { return default; }
	///<summary>SetNameOverride</summary>
	public  void SetNameOverride(string NewPropertyName) {}
}
