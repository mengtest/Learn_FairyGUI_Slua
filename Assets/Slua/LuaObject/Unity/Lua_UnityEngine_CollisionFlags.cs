﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_CollisionFlags : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.CollisionFlags");
		addMember(l,0,"None");
		addMember(l,1,"CollidedSides");
		addMember(l,1,"Sides");
		addMember(l,2,"CollidedAbove");
		addMember(l,2,"Above");
		addMember(l,4,"CollidedBelow");
		addMember(l,4,"Below");
		LuaDLL.lua_pop(l, 1);
	}
}
