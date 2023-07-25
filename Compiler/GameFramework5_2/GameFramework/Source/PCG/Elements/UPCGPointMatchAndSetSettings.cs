#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGPointMatchAndSet.h")]
///<summary>This settings class is used to create a PCG node that will apply a "Match and Set" operation</summary>
public partial class UPCGPointMatchAndSetSettings : UPCGSettings {
// PCGPointMatchAndSetSettings
	public void SetMatchAndSetType(UClass InMatchAndSetType) {}
	public UClass MatchAndSetType;
	public UPCGMatchAndSetBase MatchAndSetInstance;
	public FPCGAttributePropertySelector SetTarget;
	public EPCGMetadataTypes SetTargetType;
	public EPCGMetadataTypesConstantStructStringMode SetTargetStringMode;
	public bool bSetTargetIsAttribute;
}
