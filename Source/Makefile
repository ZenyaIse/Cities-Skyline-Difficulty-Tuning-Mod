#SOURCES=Achievements.cs  Areas.cs  Demand.cs  DifficultyOptions.cs  Economy.cs  Language.cs  LevelUp.cs  LoadingExtension.cs  Milestones.cs  Mod.cs
SOURCES=*.cs DifficultyOptions/*.cs DifficultyOptions_old/*.cs

DifficultyTuningMod.dll: ${SOURCES}
	mcs -out:DifficultyTuningMod.dll -target:library -r:ColossalManaged.dll -r:ICities.dll -r:Assembly-CSharp.dll -r:UnityEngine.dll -codepage:utf8 ${SOURCES}
