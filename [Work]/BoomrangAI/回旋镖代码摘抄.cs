private Vector3 TargetLocationAfterThrow(GameObject go)
{
    if (go.GetComponent<Rigidbody2D>())
    {
        float num = 27.32f;
        float num2 = 0.74f;
        switch (Singleton<SettingsManager>.Instance.botDifficulty)
        {
        case SettingsManager.BotDifficulty.easy:
            num2 *= 0f;
            break;
        case SettingsManager.BotDifficulty.medium:
            num2 *= 0.47f;
            break;
        case SettingsManager.BotDifficulty.hard:
            num2 *= 0.9f;
            break;
        }
        float d = Easing.EaseOut((go.transform.position - base.transform.position).magnitude / num);
        return go.transform.position + go.GetComponent<Rigidbody2D>().velocity * num2 * d;
    }
    return go.transform.position;
}

private void Attacking_Enter()
{
	if (this.player.retrieveCharge > 0f)
	{
		this.StopHoldingThrow();
	}
	this.LocateTarget();
	this.CreatePath();
	this.seeker.tagPenalties[2] = 100;
	base.SetStateChangeReluctance(1.5f, 2.5f);
}

{
    this.actionTimer = 0f;
    this.actionDelay = this.GetRandomReactionTime();
    this.TakeAction();
}


protected override void SetDifficulty()
{
	switch (Singleton<SettingsManager>.Instance.botDifficulty)
	{
	case SettingsManager.BotDifficulty.easy:
		this.reactionTimes[0] = 0.6f;
		this.reactionTimes[1] = 0.7f;
		this.reactionTimes[2] = 0.85f;
		this.inputDelay = 0.3f;
		this.gettingBearingsDuration = 8f;
		break;
	case SettingsManager.BotDifficulty.medium:
		this.reactionTimes[0] = 0.41f;
		this.reactionTimes[1] = 0.52f;
		this.reactionTimes[2] = 0.63f;
		this.inputDelay = 0.25f;
		this.gettingBearingsDuration = 4f;
		break;
	case SettingsManager.BotDifficulty.hard:
		this.reactionTimes[0] = 0.1f;
		this.reactionTimes[1] = 0.25f;
		this.reactionTimes[2] = 0.35f;
		this.inputDelay = 0.2f;
		this.gettingBearingsDuration = 2f;
		break;
	case SettingsManager.BotDifficulty.impossible:
		this.reactionTimes[0] = 0.07f;
		this.reactionTimes[1] = 0.13f;
		this.reactionTimes[2] = 0.2f;
		this.inputDelay = 0.1f;
		this.gettingBearingsDuration = 0.1f;
		break;
	}
	if (Singleton<SettingsManager>.Instance.matchType == SettingsManager.MatchType.GoldenDisc || Singleton<SettingsManager>.Instance.matchType == SettingsManager.MatchType.KingOfTheHill)
	{
		this.gettingBearingsDuration *= 0.66f;
	}
	this.gettingBearingsSpeed = (Chance.PercentageTrue(50f) ? 1f : 0.05f);
	this.gettingBearingsTimer = this.gettingBearingsDuration * Random.Range(0.75f, 1f);
}

	if (Singleton<SettingsManager>.Instance.botDifficulty == SettingsManager.BotDifficulty.easy)
	{
		num = 90f;
		if (this.player.HasDiscs == 0)
		{
			num *= 0.1f;
		}
	}


protected override void Throw(GameObject go)
{
base.Throw(go);
float probability = 100f;
switch (Singleton<SettingsManager>.Instance.botDifficulty)
{
case SettingsManager.BotDifficulty.easy:
    probability = 80f;
    break;
case SettingsManager.BotDifficulty.medium:
    probability = 90f;
    break;
case SettingsManager.BotDifficulty.hard:
    probability = 95f;
    break;
}




if (Singleton<SettingsManager>.Instance.botDifficulty == SettingsManager.BotDifficulty.easy)
{
    if (Chance.PercentageTrue(66f))
    {
        vector = VectorExt.RotatePointAroundPivot(vector, Vector2.zero, new Vector3(0f, 0f, Random.Range(-30f, 30f)));
    }
    else
    {
        vector = this.player.transform.up;
    }
}
if (Singleton<SettingsManager>.Instance.botDifficulty == SettingsManager.BotDifficulty.medium)
{
    vector = new Vector2((base.transform.up.x + vector.x) * 0.5f, (base.transform.up.y + vector.y) * 0.5f);
    this.player.RotateSnapTo(vector);
}
else
{
    this.player.RotateSnapTo(vector);
}


SettingsManager.BotDifficulty botDifficulty = Singleton<SettingsManager>.Instance.botDifficulty;
if (botDifficulty != SettingsManager.BotDifficulty.easy)
{
    if (botDifficulty == SettingsManager.BotDifficulty.medium)
    {
        
		 = 80f;
    }
}
else
{
    probability = 60f;
}
