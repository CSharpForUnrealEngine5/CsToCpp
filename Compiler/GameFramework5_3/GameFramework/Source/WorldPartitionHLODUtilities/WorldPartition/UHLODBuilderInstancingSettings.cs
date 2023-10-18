namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/HLOD/Builders/HLODBuilderInstancing.h")]
public partial class UHLODBuilderInstancingSettings : UHLODBuilderSettings {
	public static UClass StaticClass() {return default;}
	///<summary>If enabled, the components created for the HLODs will not use Nanite.</summary>
	public bool bDisallowNanite;
}
