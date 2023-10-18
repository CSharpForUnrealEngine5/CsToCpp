namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base of property view allows you to display the value of an object properties.</summary>
[CppInclude("Components/PropertyViewBase.h")]
public partial class UPropertyViewBase : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>The object to view.</summary>
	public TSoftObjectPtr<UObject> Object;
	///<summary>SoftObjectPath_DEPRECATED</summary>
	public FSoftObjectPath SoftObjectPath_DEPRECATED;
	///<summary>Load the object (if it&#39;s an asset) when the widget is created.</summary>
	public bool bAutoLoadAsset;
	///<summary>Sets a delegate called when the property value changes</summary>
	public FOnPropertyValueChanged OnPropertyChanged;
	///<summary>GetObject</summary>
	public UObject GetObject() { return default; }
	///<summary>SetObject</summary>
	public void SetObject(UObject NewObject) {}
}
