namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/VCamObjectWithInputFactory.h")]
public partial class UVCamObjectWithInputFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>The parent class of the created blueprint</summary>
	public UClass ParentClass;
	///<summary>InputMappingContext</summary>
	public UInputMappingContext InputMappingContext;
	///<summary>MappingPriority</summary>
	public int MappingPriority;
}
