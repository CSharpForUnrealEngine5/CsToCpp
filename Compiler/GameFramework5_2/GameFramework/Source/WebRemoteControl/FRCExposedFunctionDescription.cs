#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCExposedFunctionDescription {
// RCExposedFunctionDescription
	public string DisplayName;
	public string ID;
	public FRCFunctionDescription UnderlyingFunction;
	public TArray<FRCObjectDescription> OwnerObjects;
}
