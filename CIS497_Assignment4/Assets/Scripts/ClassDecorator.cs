﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ClassDecorator : Unit
{
    public override abstract string GetDescription();
    public override abstract string GetDmgType();
    public override abstract int GetLevel();
    public override abstract int GetHP();


}
