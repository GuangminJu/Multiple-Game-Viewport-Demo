// Copyright Epic Games, Inc. All Rights Reserved.

#include "CGVDemo_5_2GameMode.h"
#include "CGVDemo_5_2Character.h"
#include "UObject/ConstructorHelpers.h"

ACGVDemo_5_2GameMode::ACGVDemo_5_2GameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPerson/Blueprints/BP_ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
