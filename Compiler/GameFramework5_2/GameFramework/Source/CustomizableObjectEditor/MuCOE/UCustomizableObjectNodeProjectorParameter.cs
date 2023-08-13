namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeProjectorParameter.h")]
public partial class UCustomizableObjectNodeProjectorParameter : UCustomizableObjectNode {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultValue</summary>
	public FCustomizableObjectProjector DefaultValue;
	///<summary>ParameterName</summary>
	public string ParameterName;
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
