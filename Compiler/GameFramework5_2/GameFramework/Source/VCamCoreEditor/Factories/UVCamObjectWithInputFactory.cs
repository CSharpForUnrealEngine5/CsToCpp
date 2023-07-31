#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/VCamObjectWithInputFactory.h")]
public partial class UVCamObjectWithInputFactory : UFactory {
	///<summary>The parent class of the created blueprint</summary>
	public UClass ParentClass;
	///<summary>InputMappingContext</summary>
	public UInputMappingContext InputMappingContext;
	///<summary>MappingPriority</summary>
	public int MappingPriority;
}
