namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/LightWeightInstanceFactory.h")]
public partial class ULightWeightInstanceFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>The parent class of the created blueprint</summary>
	public UClass ParentClass;
}
