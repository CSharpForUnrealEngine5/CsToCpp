namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Factory for creating SlateStyles</summary>
[CppInclude("Factories/SlateWidgetStyleAssetFactory.h")]
public partial class USlateWidgetStyleAssetFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>StyleType</summary>
	public UClass StyleType;
}
