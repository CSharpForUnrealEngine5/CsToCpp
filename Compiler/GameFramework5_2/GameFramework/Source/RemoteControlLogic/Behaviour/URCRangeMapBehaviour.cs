namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Custom behaviour for Set Asset By Path Logic Behaviour</summary>
[CppInclude("Behaviour/Builtin/RangeMap/RCRangeMapBehaviour.h")]
public partial class URCRangeMapBehaviour : URCBehaviour {
	public static UClass StaticClass() {return default;}
	///<summary>Pointer to property container</summary>
	public URCVirtualPropertyContainerBase PropertyContainer;
	///<summary>Container holding all FRCRangeMapInputs correlating to each Action in the ActionContainer.</summary>
	public TMap<URCAction,FRCRangeMapInput> RangeMapActionContainer;
}
