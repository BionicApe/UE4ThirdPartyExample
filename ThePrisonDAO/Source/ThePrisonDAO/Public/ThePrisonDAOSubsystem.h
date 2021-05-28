// Created by Bionic Ape. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "Subsystems/GameInstanceSubsystem.h"
#include "ThePrisonDAOSubsystem.generated.h"

/**
 *
 */
UCLASS(Config = BionicApe)
class THEPRISONDAO_API UThePrisonDAOSubsystem : public UGameInstanceSubsystem
{
	GENERATED_BODY()


public:


	UPROPERTY(Config)
	FString DatabaseURL;

	UPROPERTY(Config)
	FString DatabaseUsername;

	UPROPERTY(Config)
	FString DatabasePassword;

public:

	virtual void Initialize(FSubsystemCollectionBase& Collection) override;

	virtual void Deinitialize() override;

	UFUNCTION(BlueprintCallable)
	virtual void ExecuteQuery();
};
