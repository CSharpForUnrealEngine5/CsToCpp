#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FoliageInstancedStaticMeshComponent.h")]
public partial class UFoliageInstancedStaticMeshComponent : UHierarchicalInstancedStaticMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>OnInstanceTakePointDamage</summary>
	public FInstancePointDamageSignature OnInstanceTakePointDamage;
	///<summary>OnInstanceTakeRadialDamage</summary>
	public FInstanceRadialDamageSignature OnInstanceTakeRadialDamage;
	///<summary>bEnableDiscardOnLoad</summary>
	public bool bEnableDiscardOnLoad;
	///<summary>FoliageHiddenEditorViews</summary>
	public ulong FoliageHiddenEditorViews;
	///<summary>GenerationGuid</summary>
	public FGuid GenerationGuid;
}
