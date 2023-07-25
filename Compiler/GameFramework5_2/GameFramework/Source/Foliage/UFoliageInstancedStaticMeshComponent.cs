#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FoliageInstancedStaticMeshComponent.h")]
public partial class UFoliageInstancedStaticMeshComponent : UHierarchicalInstancedStaticMeshComponent {
// FoliageInstancedStaticMeshComponent
	public FInstancePointDamageSignature OnInstanceTakePointDamage;
	public FInstanceRadialDamageSignature OnInstanceTakeRadialDamage;
	public bool bEnableDiscardOnLoad;
	public ulong FoliageHiddenEditorViews;
	public FGuid GenerationGuid;
}
