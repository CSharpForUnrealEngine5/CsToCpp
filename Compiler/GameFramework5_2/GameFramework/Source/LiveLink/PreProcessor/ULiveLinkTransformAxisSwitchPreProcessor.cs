#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PreProcessor/LiveLinkAxisSwitchPreProcessor.h")]
///<summary>Allows to switch any axis of an incoming transform with another axis.</summary>
public partial class ULiveLinkTransformAxisSwitchPreProcessor : ULiveLinkFramePreProcessor {
// LiveLinkTransformAxisSwitchPreProcessor
	public ELiveLinkAxis OrientationAxisX_DEPRECATED;
	public ELiveLinkAxis OrientationAxisY_DEPRECATED;
	public ELiveLinkAxis OrientationAxisZ_DEPRECATED;
	public ELiveLinkAxis TranslationAxisX_DEPRECATED;
	public ELiveLinkAxis TranslationAxisY_DEPRECATED;
	public ELiveLinkAxis TranslationAxisZ_DEPRECATED;
	public ELiveLinkAxis FrontAxis;
	public ELiveLinkAxis RightAxis;
	public ELiveLinkAxis UpAxis;
	public bool bUseOffsetPosition;
	public bool bUseOffsetOrientation;
	public FVector OffsetPosition;
	public FRotator OffsetOrientation;
}
