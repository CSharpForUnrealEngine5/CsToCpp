namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A helper for performing various kinds of ray cast.</summary>
[CppInclude("LearningAgentsHelpers.h")]
public partial class URayCastHelper : ULearningAgentsHelper {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new ray cast helper to the given manager component.</summary>
	public static URayCastHelper AddRayCastHelper(ULearningAgentsManagerComponent InManagerComponent,FName Name/*=NAME_None*/) { return default; }
	///<summary>Samples a grid of heights from above.</summary>
	public void RayCastGridHeights(TArray<float> OutHeights,int AgentId,FVector Position,FRotator Rotation,int RowNum/*=5*/,int ColNum/*=5*/,float RowWidth/*=1000.0f*/,float ColWidth/*=1000.0f*/,float MaxHeight/*=10000.0f*/,float MinHeight/*=-10000.0f*/,ECollisionChannel CollisionChannel/*=ECollisionChannel.ECC_WorldStatic*/) {}
	///<summary>Casts rays out in a radius from a given position.</summary>
	public void RayCastRadial(TArray<float> OutDistances,int AgentId,FVector Position,FRotator Rotation,int RayNum/*=7*/,float MinAngle/*=-90.0f*/,float MaxAngle/*=90.0f*/,float MaxRayDist/*=500.0f*/,FVector LocalForward/*=FVector.ForwardVector*/,ECollisionChannel CollisionChannel/*=ECollisionChannel.ECC_WorldStatic*/) {}
}
