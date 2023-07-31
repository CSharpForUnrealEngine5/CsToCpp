#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Custom behaviour for Set Asset By Path Logic Behaviour</summary>
[CppInclude("Behaviour/Builtin/RangeMap/RCRangeMapBehaviour.h")]
public partial class URCRangeMapBehaviour : URCBehaviour {
	///<summary>Pointer to property container</summary>
	public URCVirtualPropertyContainerBase PropertyContainer;
	///<summary>Container holding all FRCRangeMapInputs correlating to each Action in the ActionContainer.</summary>
	public TMap<URCAction,FRCRangeMapInput> RangeMapActionContainer;
}
