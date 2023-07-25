#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/PropertyViewBase.h")]
///<summary>Base of property view allows you to display the value of an object properties.</summary>
public partial class UPropertyViewBase : UWidget {
// PropertyViewBase
	public TSoftObjectPtr<UObject> Object;
	public FSoftObjectPath SoftObjectPath_DEPRECATED;
	public bool bAutoLoadAsset;
	public FOnPropertyValueChanged OnPropertyChanged;
	public UObject GetObject() { return default; }
	public void SetObject(UObject NewObject) {}
}
