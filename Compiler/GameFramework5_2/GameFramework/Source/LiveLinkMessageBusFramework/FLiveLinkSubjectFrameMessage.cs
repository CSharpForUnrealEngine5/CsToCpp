namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkMessages.h")]
public partial struct FLiveLinkSubjectFrameMessage {
	public string SubjectName;
	public TArray<FTransform> Transforms;
	public TArray<FLiveLinkCurveElement> Curves;
	public FLiveLinkMetaData MetaData;
	public double Time;
}
