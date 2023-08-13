namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConfigPropertyHelper.h")]
public partial class UConfigHierarchyPropertyView : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>EditProperty</summary>
	public object EditProperty;
	///<summary>ConfigFilePropertyObjects</summary>
	public TArray<UPropertyConfigFileDisplayRow> ConfigFilePropertyObjects;
}
