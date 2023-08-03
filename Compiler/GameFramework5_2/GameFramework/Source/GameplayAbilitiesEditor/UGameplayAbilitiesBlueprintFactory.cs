#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayAbilitiesBlueprintFactory.h")]
public partial class UGameplayAbilitiesBlueprintFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>The type of blueprint that will be created</summary>
	public EBlueprintType BlueprintType;
	///<summary>The parent class of the created blueprint</summary>
	public UClass ParentClass;
}
