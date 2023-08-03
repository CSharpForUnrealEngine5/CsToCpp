#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A helper actor that collects the ARComponent in the scene and apply the passthrough material to them.</summary>
[CppInclude("ARPassthroughManager.h")]
public partial class AARPassthroughManager : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>GetPassthroughMaterialUpdateComponent</summary>
	public  UPassthroughMaterialUpdateComponent GetPassthroughMaterialUpdateComponent() { return default; }
	///<summary>What kinds of AR components should be gathered</summary>
	public TArray<UClass> ARComponentClasses;
	///<summary>PassthroughUpdateComponent</summary>
	public UPassthroughMaterialUpdateComponent PassthroughUpdateComponent;
}
