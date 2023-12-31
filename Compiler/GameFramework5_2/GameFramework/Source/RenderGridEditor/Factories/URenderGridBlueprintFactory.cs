namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The factory that creates URenderGridBlueprint (render grid) instances.</summary>
[CppInclude("Factories/RenderGridFactory.h")]
public partial class URenderGridBlueprintFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>The parent class of the created blueprint.</summary>
	public UClass ParentClass;
}
