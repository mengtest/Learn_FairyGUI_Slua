﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioCompressionFormat : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.AudioCompressionFormat");
		addMember(l,0,"PCM");
		addMember(l,1,"Vorbis");
		addMember(l,2,"ADPCM");
		addMember(l,3,"MP3");
		addMember(l,4,"VAG");
		addMember(l,5,"HEVAG");
		addMember(l,6,"XMA");
		addMember(l,7,"AAC");
		addMember(l,8,"GCADPCM");
		LuaDLL.lua_pop(l, 1);
	}
}
