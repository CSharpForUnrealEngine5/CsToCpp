namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeProjectorConstant.h")]
public partial class UCustomizableObjectNodeProjectorConstant : UCustomizableObjectNode {
	public static UClass StaticClass() {return default;}
	///<summary>Value</summary>
	public FCustomizableObjectProjector Value;
	///<summary>ParamUIMetadata</summary>
	public FMutableParamUIMetadata ParamUIMetadata;
	///<summary>ProjectionType</summary>
	public ECustomizableObjectProjectorType ProjectionType;
	///<summary>ProjectionAngle</summary>
	public float ProjectionAngle;
	///<summary>ReferenceSkeletonIndex</summary>
	public uint ReferenceSkeletonIndex;
	///<summary>ProjectorBone</summary>
	public string ProjectorBone;
}
