namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A helper component that renders the latest point cloud from the ARCore tracking session.</summary>
[CppInclude("GoogleARCorePointCloudRendererComponent.h")]
public partial class UDEPRECATED_GoogleARCorePointCloudRendererComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The color of the point.</summary>
	public FColor PointColor;
	///<summary>The size of the point.</summary>
	public float PointSize;
}
