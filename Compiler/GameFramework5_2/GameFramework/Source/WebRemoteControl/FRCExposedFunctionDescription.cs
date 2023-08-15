namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCExposedFunctionDescription {
	public FName DisplayName;
	public string ID;
	public FRCFunctionDescription UnderlyingFunction;
	public TArray<FRCObjectDescription> OwnerObjects;
}
