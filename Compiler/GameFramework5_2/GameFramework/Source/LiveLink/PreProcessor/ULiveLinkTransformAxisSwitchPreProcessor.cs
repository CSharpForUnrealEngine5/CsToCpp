#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows to switch any axis of an incoming transform with another axis.</summary>
[CppInclude("PreProcessor/LiveLinkAxisSwitchPreProcessor.h")]
public partial class ULiveLinkTransformAxisSwitchPreProcessor : ULiveLinkFramePreProcessor {
	public static UClass StaticClass() {return default;}
	///<summary>OrientationAxisX_DEPRECATED</summary>
	public ELiveLinkAxis OrientationAxisX_DEPRECATED;
	///<summary>OrientationAxisY_DEPRECATED</summary>
	public ELiveLinkAxis OrientationAxisY_DEPRECATED;
	///<summary>OrientationAxisZ_DEPRECATED</summary>
	public ELiveLinkAxis OrientationAxisZ_DEPRECATED;
	///<summary>TranslationAxisX_DEPRECATED</summary>
	public ELiveLinkAxis TranslationAxisX_DEPRECATED;
	///<summary>TranslationAxisY_DEPRECATED</summary>
	public ELiveLinkAxis TranslationAxisY_DEPRECATED;
	///<summary>TranslationAxisZ_DEPRECATED</summary>
	public ELiveLinkAxis TranslationAxisZ_DEPRECATED;
	///<summary>FrontAxis</summary>
	public ELiveLinkAxis FrontAxis;
	///<summary>RightAxis</summary>
	public ELiveLinkAxis RightAxis;
	///<summary>UpAxis</summary>
	public ELiveLinkAxis UpAxis;
	///<summary>bUseOffsetPosition</summary>
	public bool bUseOffsetPosition;
	///<summary>bUseOffsetOrientation</summary>
	public bool bUseOffsetOrientation;
	///<summary>OffsetPosition</summary>
	public FVector OffsetPosition;
	///<summary>OffsetOrientation</summary>
	public FRotator OffsetOrientation;
}
