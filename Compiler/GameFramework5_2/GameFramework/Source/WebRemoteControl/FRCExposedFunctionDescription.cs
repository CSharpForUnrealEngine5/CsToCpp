#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCExposedFunctionDescription {
	public string DisplayName;
	public string ID;
	public FRCFunctionDescription UnderlyingFunction;
	public TArray<FRCObjectDescription> OwnerObjects;
}
