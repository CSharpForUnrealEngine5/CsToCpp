#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SinglePropertyView.h")]
///<summary>The single property view allows you to display the value of an object's property.</summary>
public partial class USinglePropertyView : UPropertyViewBase {
// SinglePropertyView
	public string PropertyName;
	public string NameOverride;
	public string GetPropertyName() { return default; }
	public void SetPropertyName(string NewPropertyName) {}
	public string GetNameOverride() { return default; }
	public void SetNameOverride(string NewPropertyName) {}
}
