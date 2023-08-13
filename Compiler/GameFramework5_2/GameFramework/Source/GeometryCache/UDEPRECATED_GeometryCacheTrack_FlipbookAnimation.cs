namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Derived GeometryCacheTrack class, used for Transform animation.</summary>
[CppInclude("GeometryCacheTrackFlipbookAnimation.h")]
public partial class UDEPRECATED_GeometryCacheTrack_FlipbookAnimation : UGeometryCacheTrack {
	public static UClass StaticClass() {return default;}
	///<summary>Add a GeometryCacheMeshData sample to the Track</summary>
	public void AddMeshSample(FGeometryCacheMeshData MeshData,float SampleTime) {}
	///<summary>Number of Mesh Sample within this track</summary>
	public uint NumMeshSamples;
}
