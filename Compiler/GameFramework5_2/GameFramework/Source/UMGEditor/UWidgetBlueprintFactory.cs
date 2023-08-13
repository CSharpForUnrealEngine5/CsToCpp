namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WidgetBlueprintFactory.h")]
public partial class UWidgetBlueprintFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>The type of blueprint that will be created</summary>
	public EBlueprintType BlueprintType;
	///<summary>The parent class of the created blueprint</summary>
	public UClass ParentClass;
	///<summary>RootWidgetClass</summary>
	public UClass RootWidgetClass;
}
