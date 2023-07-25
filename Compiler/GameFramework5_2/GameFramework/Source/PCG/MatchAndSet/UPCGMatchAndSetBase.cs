#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MatchAndSet/PCGMatchAndSetBase.h")]
///<summary>Base class for Match & Set objects. Note that while it currently deals with points, it might be extended in the future.</summary>
public partial class UPCGMatchAndSetBase : UObject {
// PCGMatchAndSetBase
	public bool ValidatePreconditions(UObject InPointData) { return default; }
	public void MatchAndSet(FPCGContext Context,UObject InSettings,UObject InPointData,UObject OutPointData) {}
	public EPCGMetadataTypes Type;
	public EPCGMetadataTypesConstantStructStringMode StringMode;
}
