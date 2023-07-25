#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/DataLayer/DataLayerAsset.h")]
public partial class UDataLayerAsset : UObject {
// DataLayerAsset
	public EDataLayerType GetType() { return default; }
	public bool IsRuntime() { return default; }
	public FColor GetDebugColor() { return default; }
	public EDataLayerType DataLayerType;
	public FColor DebugColor;
}
