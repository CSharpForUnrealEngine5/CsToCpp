namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the MassSmartObject module.</summary>
[CppInclude("MassSmartObjectSettings.h")]
public partial class UMassSmartObjectSettings : UMassModuleSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Tag used to indicate that smart objects are associated to a lane for queries using lanes.</summary>
	public FZoneGraphTag SmartObjectTag;
	///<summary>Extents used to find precomputed entry points to reach a smart object from a zone graph lane.</summary>
	public float SearchExtents;
}
