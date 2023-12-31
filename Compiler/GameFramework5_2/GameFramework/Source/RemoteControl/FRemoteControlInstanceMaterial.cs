namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a material instance property that has been exposed to remote control.</summary>
[CppInclude("RemoteControlInstanceMaterial.h")]
public partial struct FRemoteControlInstanceMaterial {
	public UClass OriginalClass;
	public FMaterialParameterInfo ParameterInfo;
	public FRCFieldPathInfo OriginalFieldPathInfo;
	public FSoftObjectPath InstancePath;
}
