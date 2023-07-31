#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/BlueprintFactory.h")]
public partial class UBlueprintFactory : UFactory {
	///<summary>The parent class of the created blueprint</summary>
	public UClass ParentClass;
	///<summary>The type of Blueprint to create in FactoryCreateNew</summary>
	public EBlueprintType BlueprintType;
	///<summary>Skips the class choosing dialog and uses the ParentClass as the blueprint base class</summary>
	public bool bSkipClassPicker;
}
