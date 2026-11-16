#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "BraveContinentGameMode.generated.h"

/** 游戏规则的 C++ 基类，蓝图子类可配置内容与表现。 */
UCLASS(Blueprintable, hidecategories = (Input, Movement, Collision, Rendering, HLOD), meta = (DisplayName = "勇者大陆游戏模式", Category = "游戏规则"))
class BRAVECONTINENT_API ABraveContinentGameMode : public AGameModeBase
{
	GENERATED_BODY()
};
